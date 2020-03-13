using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = {0, 2, 4, 6, 8, 10};
            int[] arrayB = {1, 3, 5, 7, 9};
            int[] arrayC = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};

            ManipulatingArrays homework = new ManipulatingArrays();
            Console.WriteLine("Part1");
            homework.SumAndAverage(arrayA);
            homework.SumAndAverage(arrayB);
            homework.SumAndAverage(arrayC);
            Console.WriteLine("Part2");
            homework.Reverse(arrayA);
            homework.Reverse(arrayB);
            homework.Reverse(arrayC);
            Console.WriteLine("Part3");
            homework.Rotate(arrayA, "Right", 2);
            homework.Rotate(arrayB, "Left", 2);
            homework.Rotate(arrayC, "Left", 4);
            Console.WriteLine("Part4");
            Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", arrayC));
            homework.Sort(arrayC, 0, arrayC.Length - 1);
            Console.WriteLine("The sorted array is like: " + "[{0}]", string.Join(" ", arrayC));
        }

    }
    class ManipulatingArrays
    {
        public void Sort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int left = start;
            int right = end;
            int pivot = array[(start + end) / 2];
            while (left <= right)
            {
                while (left <= right && array[left] < pivot)
                {
                    left++;
                }
                while (left <= right && array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
            Sort(array, start, right);
            Sort(array, left, end);
        }
        public void Rotate(int[] array, string direction, int place)
        {
            if (direction == "Left")
            {
                Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", array));
                Console.WriteLine("To rotate the this array to the " + direction + " by " + place + " is: ");
                for (int i = place; i < place + array.Length; i++)
                {
                    int j = i;
                    if (i >= array.Length)
                    {
                        j = i - array.Length;
                    }
                    Console.Write(array[j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            if (direction == "Right")
            {
                Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", array));
                Console.WriteLine("To rotate the this array to the " + direction + " by " + place + " is: ");
                for (int i = array.Length - place; i < array.Length + array.Length - place; i++)
                {
                    int j = i;
                    if (i >= array.Length)
                    {
                        j = i - array.Length;
                    }
                    Console.Write(array[j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void Reverse(int[] array)
        {
            Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", array));
            int[] copy = new int[array.Length];
            array.CopyTo(copy, 0);
            Array.Reverse(copy);
            Console.WriteLine("The reverse is like: " + "[{0}]", string.Join(", ", copy));
            Console.WriteLine();
        }
        public void SumAndAverage(int[] array)
        {
            Console.WriteLine("For the array: " + "[{0}]", string.Join(" ", array));
            Console.WriteLine("The length of this array is: " + array.Length);
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine("The sum of this array is: " + sum);
            Console.WriteLine("The mean value of this array is: " + average);
            Console.WriteLine();
        }
    }
}
