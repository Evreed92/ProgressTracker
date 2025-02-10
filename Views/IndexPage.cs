using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Interfaces;
using ProjectTracker.Views;
using ProjectTracker.Controllers;

namespace ProjectTracker.Views
{
    public class IndexPage : IView
    {
        public IView Login()
        {
            bool _loginfailed = true;
            string? userName = null;
            while (_loginfailed)
            {
                Console.WriteLine("--Welcome--");
                Console.WriteLine("Please enter your userName");
                userName = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                var password = Console.ReadLine();
                //Work out password hashing for security

                //call DB to check userName and password

                if (userName == null || password == null)
                {
                    ErrorPage error = new ErrorPage();
                    return error.LoginError("Please Input a UserName or Password");
                }
                else if (userName != "evanreed" || password != "password")
                {
                    ErrorPage error = new ErrorPage();
                    return error.LoginError("Incorrect UserName or Password");
                }
                else
                {
                    _loginfailed = false;
                    Console.Clear();
                    UserPage home = new UserPage();
                }
            }
            return new UserPage().Home(userName);
        }
    }
}
