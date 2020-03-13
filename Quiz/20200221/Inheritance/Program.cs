using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Firearm firearm = new Firearm();
            firearm.Work("I am a firearm I shoot things.");
            Shotgun shotgun = new Shotgun();
            shotgun.Work("I am a shotgun I go Boom.");
            Rifle rifle = new Rifle();
            rifle.Work("I am a rifle I go Bang.");
            Pistol pistol = new Pistol();
            pistol.Work("I am a pistol I go Pop.");
        }
    }
    class Firearm
    {
        public void Work(string something)
        {
            Console.WriteLine(something);
        }
    }
    class Shotgun : Firearm
    {
        public void Work(string something)
        {
            Console.WriteLine(something);
        }
    }
    class Rifle : Firearm
    {
        public void Work(string something)
        {
            Console.WriteLine(something);
        }
    }
    class Pistol : Firearm
    {
        public void Work(string something)
        {
            Console.WriteLine(something);
        }

    }
}
