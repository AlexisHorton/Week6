using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkedThruMockb.Models
{
    public class Person
    {
        public int Age { get; set; }
        public string Username { get; set; }
        public bool CanDrink { 
            get
            {
                return Age >= 21;
            }
        }
        public bool CanDrive
        {
            get
            {
                return Age >= 16;
            }
        }
    }
}
