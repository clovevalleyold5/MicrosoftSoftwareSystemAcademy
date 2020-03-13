using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Vehicles
    {
        public void Start()
        {
            Console.WriteLine("Start Engine");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Diving Vehicle");
        }
        public void Price()
        {
            Console.WriteLine("500");
        }
    }
    class Vehicle1 : Vehicles
    {
        public void Price()
        {
            Console.WriteLine("V1's Price");
        }
        public override void Drive()
        {
            Console.WriteLine("Driving V1");
        }
    }
    class Vehicle2 : Vehicles
    {
        public void Price()
        {
            Console.WriteLine("V2's Price");
        }
        public override void Drive()
        {
            Console.WriteLine("Driving V2");
        }
    }
    class Vehicle3 : Vehicles
    {
        public void Price()
        {
            Console.WriteLine("V2's Price");
        }
        public override void Drive()
        {
            Console.WriteLine("Driving V3");
        }
    }
}
