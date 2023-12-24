using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public interface IRegister
    {   
        //the parameter represents the correct form of data which will be proceed to be stored in to the database
        bool Register(string[] fields);
        bool EmailExists(string emailAddress);
    }
}
