using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker
{
    public class View
    {
        public void HomePage(ProjectsManager manager)
        {
            bool _quit = false;
            while (_quit == false)
            {
                Console.WriteLine("------Progress Tracker App------");
            Console.WriteLine("Your Current Projects Projects");
            Console.WriteLine("------------------------------");
            if (manager.Projects.Count <= 0) { Console.WriteLine("You have no current Projects"); }
            else
            {
                foreach (var project in manager.Projects)
                {
                    Console.WriteLine(project.Name + " Last Worked On: " + project.Tracklist.Tail.Date.ToString());
                }
            }
            
                Console.WriteLine("Menu: Add Project(P); Quit (Q)");
                var response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "P":
                        Console.WriteLine("New Project Method Call Here. Press Another Key..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "Q":
                        Console.WriteLine("Quit");
                        _quit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect Input. Press Another Key..");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }
                
            }
        }
    }
}
