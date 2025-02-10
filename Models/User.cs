using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        public User(string firstName, string lastName, int userId)
        {
            FirstName = firstName;
            LastName = lastName;
            UserId = userId;
        }
    }
}
