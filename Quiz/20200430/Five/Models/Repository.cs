using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Text;

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
        public static List<Spartan> LoadRoster()
        {
            List<Spartan> roster = new List<Spartan>();
            var reader = new StreamReader(@"C:\Users\Five\MSSA\Quiz\20200430\roster.csv");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] spartanData = line.Split(',');
                if (!String.IsNullOrEmpty(spartanData[0]))
                {
                    roster.Add(new Spartan { Name = spartanData[0], Height = spartanData[1], Weight = spartanData[2], Gender = spartanData[3] });
                }
            }
            return roster;
        }
        public static string SaveRoster()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < spartans.Count; i++)
            {
                Spartan spartan = spartans[i];
                sb.Append(spartan.Name + ',');
                sb.Append(spartan.Height + ',');
                sb.Append(spartan.Weight + ',');
                sb.Append(spartan.Gender);
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
    }
}