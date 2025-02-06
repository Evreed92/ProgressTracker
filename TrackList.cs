using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker
{
public class TrackList
    {
        public Track? Head;
        public Track? Tail;

        public void AddTrack(string description)
        {
            Track current = new Track(null, description, new DateTime());
            if (Head == null)
            {
                Head = current;
                Tail = null;
            }
            else
            {
                Tail.NextTrack = current;
                Tail = current;
            }
        }
    }
}
