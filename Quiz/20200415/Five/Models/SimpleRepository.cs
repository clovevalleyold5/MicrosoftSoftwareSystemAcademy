using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Five.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedrepository = new SimpleRepository();
        private Dictionary<string, Person> people = new Dictionary<string, Person>();
        public static SimpleRepository SharedRepository => sharedrepository;
        public SimpleRepository()
        {
            var group = new[]
            {
                new Person{Name="Jameson Locke",Height="208",Weight="116",Gender="Male"},
                new Person{Name="Holly Tanaka",Height="201",Weight="108",Gender="Female"},
                new Person{Name="Olympia Vale",Height="206",Weight="102",Gender="Female"},
                new Person{Name="Edward Buck",Height="206",Weight="113",Gender="Male"}
            };
            foreach (var p in group)
            {
                AddPerson(p);
            }
        }
        public IEnumerable<Person> People => people.Values;
        public void AddPerson(Person p) => people.Add(p.Name, p);
    }
}
