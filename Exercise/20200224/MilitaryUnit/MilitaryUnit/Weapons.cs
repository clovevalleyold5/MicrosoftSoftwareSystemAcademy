using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapons
    {
        protected int weight;
        public int getWeight()
        {
            return weight;
        }
        public void SetWeight()
        {
            weight = 0;
        }
        public void Aim()
        {
            Console.WriteLine("Aim");
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Shoot Bullets");
        }
    }
    class Weapon1 : Weapons
    {
        public void SetWeight()
        {
            weight = 20;
        }
        public void SetWeight(int wweight)
        {
            weight = wweight;
        }
        public override void Shoot()
        {
            Console.WriteLine("Shoot W1's Bullets"); 
        }
    }
    class Weapon2 : Weapons
    {
        public void Weight()
        {
            Console.WriteLine("W2's Weight");
        }
        public override void Shoot()
        {
            Console.WriteLine("Shoot W2's Bullets");
        }
    }
    class Weapon3 : Weapons
    {
        public void Weight()
        {
            Console.WriteLine("W3's Weight");
        }
        public override void Shoot()
        {
            Console.WriteLine("Shoot W3's Bullets");
        }
    }
}
