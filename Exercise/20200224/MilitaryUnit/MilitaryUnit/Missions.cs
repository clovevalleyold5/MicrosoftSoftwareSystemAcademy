using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Missions
    {
        public void Excute()
        {
            Console.WriteLine("Excute Mission");
        }
        public virtual void Detail()
        {
            Console.WriteLine("Mission Detail:");
        }
        public virtual void Detail(Personnel[] person, Weapons weapon, Vehicles vehicle)
        {
            
        }
        public virtual void Date()
        {
            Console.WriteLine("Mission Date:");
        }
    }
    class Mission1 : Missions
    {
        public override void Detail()
        {
            base.Detail();
            Console.WriteLine("M1's Mission Detail is not clear");
        }
        public override void Detail(Personnel[] person, Weapons weapon, Vehicles vehicle) 
        {
            base.Detail();
            Console.WriteLine("Name and specialty:");
            foreach (Personnel p in person)
            {
                Console.WriteLine(p.getName());
                p.Specialty();
            }
            Console.WriteLine("Weapon used in this mission weight:");
            Console.WriteLine(weapon.getWeight());

            Console.WriteLine("Vihicle used in this mission:");
            vehicle.Price();

        }
       
        public override void Date()
        {
            Console.WriteLine("M1's Date");
        }
    }
    class Mission2 : Missions
    {
        public void Detail()
        {
            Console.WriteLine("M2's Mission Detail");
        }
        public override void Date()
        {
            Console.WriteLine("M2's Date");
        }
    }
    class Mission3 : Missions
    {
        public void Detail()
        {
            Console.WriteLine("M3's Mission Detail");
        }
        public override void Date()
        {
            Console.WriteLine("M3's Date");
        }
    }
}
