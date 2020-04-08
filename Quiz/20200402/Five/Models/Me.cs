using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Five.Models
{
    public class Me
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Gender { get; set; }
        public static Me[] GetFive()
        {
            Me five = new Me { Name = "Five", Height = "178cm", Weight = "65kg", Gender = "Male" };
            return new Me[] { five };
        }
    }
}
