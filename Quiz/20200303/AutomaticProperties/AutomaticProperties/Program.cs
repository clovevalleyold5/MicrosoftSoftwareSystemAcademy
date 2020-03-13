using System;

namespace AutomaticProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Firearm pistol = new Firearm { name = "pistol", sound = "pop", caliber = "9mm" };
            pistol.work();
            Firearm rifle = new Firearm { name = "rifle", sound = "bang", caliber = "7.62mm" };
            rifle.work();
            Firearm shotgun = new Firearm { name = "shotgun", sound = "boom", caliber = "12gauge" };
            shotgun.work();
        }
        public class Firearm
        {
            public string name { get; set; }
            public string sound { get; set; }
            public string caliber { get; set; }
            static int count = 0;
            public Firearm()
            {
                count++;
            }
            public void work()
            {
                Console.WriteLine("i am a " + this.name + " and i go " + this.sound + " i fire " + this.caliber + " and we have " + count + " firearms");
            }
        }
    }
}
