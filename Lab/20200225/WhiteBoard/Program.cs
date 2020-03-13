using System;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7};
            Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", array));
            Console.WriteLine("Enter a new element 4");
            int newelement = 4;
            int[] newarray = new int[array.Length + 1];
            int i = 0;
            int j = array.Length - 1;
            while (array[i] <= newelement)
            {
                newarray[i] = array[i];
                i++;
            }
            newarray[i] = newelement;
            while (array[j] > newelement)
            {
                newarray[j + 1] = array[j];
                j--;
            }
            Console.WriteLine("The new array is: " + "[{0}]", string.Join(" ", newarray));
        }
    }
}
