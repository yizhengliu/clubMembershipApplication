using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public class ClubMembershipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string destination = "C:\\Users\\27571\\OneDrive\\桌面\\advance C#\\clubMembershipApplication\\ClubMembershipApplication\\packages\\Microsoft.EntityFrameworkCore.Tools.3.1.2\\tools\\net461\\any\\";
            //Console.WriteLine($"{AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\27571\OneDrive\桌面\advance C#\clubMembershipApplication\ClubMembershipApplication\Db\ClubMembershipDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        //get users data
        public DbSet<User> Users { get; set; }

    }
}
