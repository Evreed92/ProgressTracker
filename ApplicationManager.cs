using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker
{
    public class ApplicationManager
    {
        public ApplicationManager() {
            View page = new View();
            ProjectsManager manager = new ProjectsManager();
            page.HomePage(manager);
        
        }
    }
}
