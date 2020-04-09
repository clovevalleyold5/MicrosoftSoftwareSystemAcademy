using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Five.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Gender { get; set; }
        //public static Person[] GetFive()
        //{
        //    Person five = new Person { Name = "Five", Height = "178cm", Weight = "65kg", Gender = "Male" };
        //    return new Person[] { five };
        //}
    }
}
