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
                new Person{Name="Jameson Locke",Height="208cm",Weight="116kg",Gender="Male"},
                new Person{Name="Holly Tanaka",Height="201cm",Weight="108kg",Gender="Female"},
                new Person{Name="Olympia Vale",Height="206cm",Weight="102kg",Gender="Female"},
                new Person{Name="Edward Buck",Height="206cm",Weight="113kg",Gender="Male"}
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
