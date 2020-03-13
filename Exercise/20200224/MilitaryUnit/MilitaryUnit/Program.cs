using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Missions m1 = new Mission1();
            Personnel p1 = new Person1("P1");
            Personnel p2 = new Person2("P2");
            Personnel p3 = new Person3("P3");
            Personnel p4 = new Personnel();
            Personnel[] team = { p1, p2, p3, p4 };
            Weapons w1 = new Weapon1();
            Vehicles v1 = new Vehicles();
            m1.Excute();
            m1.Detail(team, w1, v1);
        }
    }
}
