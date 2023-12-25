using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public class LoginUser:ILogin
    {
        public User login(string emailAddress, string password)
        {
            User user = null;
            using (var dbcontext = new ClubMembershipDbContext()) 
            {
                user = dbcontext.Users.FirstOrDefault(u => u.EmailAddress.Trim().ToLower() == emailAddress.Trim().ToLower() && u.Password.Equals(password));

            }
            return user;
        }
    }
}
