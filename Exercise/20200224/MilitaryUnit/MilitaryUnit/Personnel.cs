using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        protected String name;

        public Personnel()
        {
            name = "Anounymous";
        }
        public Personnel(String pname)
        {
            name = pname;
        }
        public String getName() 
        {
            return name;
        }
        public void Deploy()
        {
            Console.WriteLine("Deploying");
        }
        public virtual void Specialty()
        {
            Console.WriteLine("This person may know everything");
        }
        public virtual void Name()
        {
            Console.WriteLine("Five");
        }
    }
    class Person1 : Personnel
    {
        public Person1()
        {
        }
        public Person1(String pname) {
            name = pname;
        }
        public override void Specialty()
        {
            Console.WriteLine("P1's Specialty");
        }
       
        public override void Name()
        {
            Console.WriteLine("P1's Name"); ;
        }
    }
    class Person2 : Personnel
    {
        public Person2()
        {
        }
        public Person2(String pname)
        {
            name = pname;
        }
        public override void Specialty()
        {
            Console.WriteLine("P2's Specialty");
        }
        public override void Name()
        {
            Console.WriteLine("P2's Name");
        }
    }
    class Person3 : Personnel
    {
        public Person3()
        { 
        }
        public Person3(String pname)
        {
            name = pname;
        }
        public override void Specialty()
        {
            Console.WriteLine("P3's Specialty");
        }
        public override void Name()
        {
            Console.WriteLine("P3's Name");
        }
    }
}
