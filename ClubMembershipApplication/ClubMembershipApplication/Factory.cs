using ClubMembershipApplication.Data;
using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication
{
    public static class Factory
    {
        public static IView GetMainViewObject() 
        {
            //using dependency inversion principle that user abstraction rather than solid classes
            ILogin login = new LoginUser();
            IRegister register = new RegisterUser();
            IFieldValidator fieldValidator = new UserRegistrationValidator(register);

            fieldValidator.InitialiseValidatorDelegates();
            IView registerView = new UserRegistrationView(register, fieldValidator);
            IView loginView = new UserLoginView(login);
            return new MainView(loginView, registerView);
        }
    }
}
