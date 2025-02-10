using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Views;

namespace ProjectTracker.Controllers
{
    public class HomeController
    {
        public HomeController()
        {
            UserPage page = new UserPage();
            UserController manager = new UserController();
            page.Home(manager);

        }
    }
}
