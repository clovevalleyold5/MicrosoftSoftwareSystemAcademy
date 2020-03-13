using System;

namespace GuessMyNumberFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("which game do you want to play? <1> human guess, <2> computer guess: ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                GuessMyNumber humanguess = new GuessMyNumber();
                Console.Write("computer choose: ");
                int computer_number = int.Parse(Console.ReadLine());
                humanguess.ComputerChooseHumanGuess(10, computer_number);
            }
            if (choose == 2)
            {
                GuessMyNumber computerguess = new GuessMyNumber();
                Console.Write("human choose: ");
                int human_number = int.Parse(Console.ReadLine());
                computerguess.HumanChooseComputerGuess(10, human_number);
            }
        }
        class GuessMyNumber
        {
            public void ComputerChooseHumanGuess(int range, int that_number)
            {
                Console.Write("human guess: ");
                int human_guess = int.Parse(Console.ReadLine());
                if (human_guess == that_number)
                {
                    Console.Write(human_guess + " is correct");
                    return;
                }
                if (human_guess > range || human_guess <= 0)
                {
                    Console.Write("input out of range, try again: ");
                    ComputerChooseHumanGuess(range, that_number);
                    return;
                }
                while (human_guess != that_number)
                {
                    HumanGuess(human_guess, that_number);
                    ComputerChooseHumanGuess(range, that_number);
                    return;
                }
            }
            public void HumanGuess(int human_guess, int that_number)
            {
                if (human_guess > that_number)
                {
                    Console.WriteLine(human_guess + " is too high");
                }
                else
                {
                    Console.WriteLine(human_guess + " is too low");
                }
            }
            public void HumanChooseComputerGuess(int range, int this_number)
            {
                ComputerGuess(0, range, this_number);
            }
            private void ComputerGuess(int start, int end, int this_number)
            {
                int mid = (start + end) / 2;
                Console.WriteLine("computer guess: " + mid);
                if (mid == this_number)
                {
                    Console.WriteLine(mid + " is correct");
                    return;
                }
                if (mid > this_number)
                {
                    Console.Write("is " + mid + " too high or too low? <1> too high, <2> too low: ");
                    int response = int.Parse(Console.ReadLine());
                    while (response != 1)
                    {
                        Console.Write("you sure? check again: ");
                        response = int.Parse(Console.ReadLine());
                    }
                    ComputerGuess(start, mid, this_number);
                }
                if (mid < this_number)
                {
                    Console.Write("is " + mid + " too high or too low? <1> too high, <2> too low: ");
                    int response = int.Parse(Console.ReadLine());
                    while (response != 2)
                    {
                        Console.Write("you sure? check again: ");
                        response = int.Parse(Console.ReadLine());
                    }
                    ComputerGuess(mid + 1, end, this_number);
                }
            }
        }
    }
}
