using System;

namespace Classes
{
    class Firearm
    {
        public static void shotgun()
        {
            Console.WriteLine("I'm a shotgun and I go Boom.");
        }
        public static void rifle()
        {
            Console.WriteLine("I'm a rifle and I go Bang.");
        }
        public static void pistol()
        {
            Console.WriteLine("I'm a pistol and I go Pop.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Test 04.");
            Firearm shotgun = new Firearm();
            Firearm.shotgun();
            Firearm rifle = new Firearm();
            Firearm.rifle();
            Firearm pistol = new Firearm();
            Firearm.pistol();
        }
    }
}
