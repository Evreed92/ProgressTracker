using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Models
{
    public class Project
    {
        public string Name;
        public TrackList Tracklist;
        //Constructor
        public Project(string name)
        {
            Name = name;
        }


    }
}
