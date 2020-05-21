using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Five.Models
{
    public static class Repository 
    {
        private static List<Spartan> spartans = Oasis();
        public static IEnumerable<Spartan> Spartans
        {
            get { return spartans; }
        }
        public static void AddSpartan(Spartan spartan)
        {
            spartans.Add(spartan);
        }
        //
        private static List<Spartan> Oasis()
        {
            List<Spartan> spartans = new List<Spartan>();
            var oasis = new[]
            {
                new Spartan{Name="Jameson Locke",Height="208",Weight="116",Gender="Male"},
                new Spartan{Name="Holly Tanaka",Height="201",Weight="108",Gender="Female"},
                new Spartan{Name="Olympia Vale",Height="206",Weight="102",Gender="Female"},
                new Spartan{Name="Edward Buck",Height="206",Weight="113",Gender="Male"}
            };
            foreach (var s in oasis)
            {
                spartans.Add(s);
            }
            return spartans;
        }
            
       
    }
}
