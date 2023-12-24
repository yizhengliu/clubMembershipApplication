using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //here we use code first apporach to set Id to be the primary key and it will auto increase

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth {  get; set; }

        public string PhoneNumber {  get; set; }

        public string AddressFirstLine { get; set; }

        public string AddressLastLine { get; set;}

        public string AddressCity { get; set; }

        public string PostCode { get; set; }
    }
}
