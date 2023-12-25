using ClubMembershipApplication.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Views
{
    internal class MainView : IView
    {
        public IFieldValidator FieldValidator => null;


        IView _registerView = null;
        IView _loginView = null;
        public MainView(IView loginView, IView registerView) 
        {
            _loginView = loginView;
            _registerView = registerView;
        }

        public void RunView()
        {
            CommonOutputText.WriteMainHeading();
            Console.WriteLine("Please press 'l' to login or if you are not yet registered please press 'r");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.R)
            {
                RunUserRegistrationView();
                RunLoginView();
            }
            else if (key == ConsoleKey.L)
            {
                RunLoginView();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
                Console.ReadKey();  
            }
        }

        private void RunUserRegistrationView() 
        {
            _registerView.RunView();
        }
        private void RunLoginView()
        {
            _loginView.RunView();
        }
    }
}
