using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shotgun shotgun = new Shotgun();
            //IFirearm myshotgun = shotgun;
            Console.WriteLine(shotgun.Something());
            Rifle rifle = new Rifle();
            //IFirearm myrifle = rifle;
            Console.WriteLine(rifle.Something());
            Pistol pistol = new Pistol();
            //IFirearm mypistol = pistol;
            Console.WriteLine(pistol.Something());
        }
    }
    interface IFirearm
    {
        string Something();
    }
    class Shotgun : IFirearm
    {
        public string Something()
        {
            return "I am a shotgun and I go Boom";
        }
    }
    class Rifle : IFirearm
    {
        public string Something()
        {
            return "I am a rifle and I go Bang";
        }
    }
    class Pistol : IFirearm
    {
        public string Something()
        {
            return "I am a pistol and I go Pop";
        }
    }
}
