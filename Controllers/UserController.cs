using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models;

namespace ProjectTracker.Controllers
{
    public class UserController
    {
        public List<Project> Projects = new List<Project>();

        public Project NewProject(string name)
        {
            return new Project(name);
        }
        public void SaveProject()
        {
        }
        public void ArchiveProject()
        {
        }

    }
}
