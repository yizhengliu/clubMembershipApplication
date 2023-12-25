﻿using ClubMembershipApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();
        }
    }
}
