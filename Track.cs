using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker
{
   public class Track 
    {
        public Track NextTrack;
        public string Description;
        public DateTime Date;

        public Track(Track nextTrack, string description, DateTime date)
        {
            NextTrack = nextTrack;
            Description = description;
            Date = date;
        } 
    }
}
