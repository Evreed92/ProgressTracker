﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Interfaces;
using ProjectTracker.Views;

namespace ProjectTracker.Views
{
    public class ErrorPage : IView
    {
        public IView LoginError(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("hit another key to continue");
            Console.ReadLine();
            Console.Clear();
            return new IndexPage().Login();
        }
    }
}
