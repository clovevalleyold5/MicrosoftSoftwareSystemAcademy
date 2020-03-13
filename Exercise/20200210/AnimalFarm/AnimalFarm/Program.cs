using System;

namespace AnimalFarm
{
    class Pig
    {
        private string name = "Pig Prototype";
        static int count;
        public void Speak(string something)
        {
            Console.WriteLine("This is pig " + count + " , its name is " + name + ", it says " + something);
        }
        public void  Eat(string something)
        {
            Console.WriteLine("This is still " + name + ", it eats " + something) ;
        }
        public Pig()
        {
            count++;
        }
        public Pig(string pigname)
        {
            count++;
            name = pigname;
        }
    }
    class Cow
    {
        private string name = "Cow Prototype";
        static int count;
        public void Speak(string something)
        {
            Console.WriteLine("This is cow " + count + ", its name is " + name + ", it says " + something);
        }
        public void Eat(string something)
        {
            Console.WriteLine("This is still " + name + ", it eats " + something);
        }
        public Cow()
        {
            count++;
        }
        public Cow(string cowname)
        {
            name = cowname;
            count++;
        }
    }
    class Chicken
    {
        private string name = "Chicken Prototype";
        static int count;
        public void Speak(string something)
        {
            Console.WriteLine("This is chicken " + count + " , its name is " + name + ", it says " + something);
        }
        public void Eat(string something)
        {
            Console.WriteLine("This is still " + name + ", it eats " + something);
        }
        public Chicken()
        {
            count++;
        }
        public Chicken(string chickenname)
        {
            name = chickenname;
            count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cox Farm.");
            Pig pig1 = new Pig("Pig1");
            pig1.Speak("Pig1's language");
            pig1.Eat("Pig1's food");
            Pig pig2 = new Pig("Pig2");
            pig2.Speak("Pig2's language");
            pig2.Eat("Pig2's food");
            Pig pig3 = new Pig();
            pig3.Speak("'Heng Heng!'");
            pig3.Eat("Swill");
            Console.WriteLine();
            Cow cow1 = new Cow("Cow1");
            cow1.Speak("Cow1's language");
            cow1.Eat("Cow1's food");
            Cow cow2 = new Cow("Cow2");
            cow2.Speak("Cow2's language");
            cow2.Eat("Cow2's food");
            Cow cow3 = new Cow();
            cow3.Speak("'Mer~'");
            cow3.Eat("Grass");
            Console.WriteLine();
            Chicken chicken1 = new Chicken("Chicken1");
            chicken1.Speak("Chicken1's language");
            chicken1.Eat("Chicken1's food");
            Chicken chicken2 = new Chicken("Chicken2");
            chicken2.Speak("Chicken2's language");
            chicken2.Eat("Chicken2's food");
            Chicken chicken3 = new Chicken();
            chicken3.Speak("'Gu Gu Gu...'");
            chicken3.Eat("Millet");
        }
    }
}
