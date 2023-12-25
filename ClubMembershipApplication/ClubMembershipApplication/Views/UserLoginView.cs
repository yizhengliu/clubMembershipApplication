using ClubMembershipApplication.Data;
using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Views
{
    public class UserLoginView : IView
    {
        ILogin _loginUser = null;

        //dont need validator
        public IFieldValidator FieldValidator => null;

        public UserLoginView(ILogin login) 
        {
            _loginUser = login;
        }

        public void RunView()
        {
            CommonOutputText.WriteMainHeading();
            CommonOutputText.WriteLoginHeading();

            Console.WriteLine("Please enter your email address");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            User user = _loginUser.login(emailAddress, password);

            if (user != null)
            {
                //user is authenticated
                //ToDo: Run Welcome View
            }
            else 
            {
                Console.Clear();
                CommonOutputFormat.ChangeFontColor(FontTheme.Danger);
                Console.WriteLine("The credentials that you entered do not match our records");
                CommonOutputFormat.ChangeFontColor(FontTheme.Default);
                Console.ReadKey();
            }

        }
    }
}
