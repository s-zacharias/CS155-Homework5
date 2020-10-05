using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        static int[] GenerateNumbers()
        {
            int[] result = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            return result;
        }

        static int[] Reverse(int[] arrayToReverse)
        {
            int temp;

            for (int i = 0; i < arrayToReverse.Length; i++)
            {
                temp = arrayToReverse[i];
                arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - i - 1];
                arrayToReverse[arrayToReverse.Length - i - 1] = temp;
            }

            return arrayToReverse;
        }

        static void PrintNumbers(int[] arrayToPrint)
        {
            foreach (int num in arrayToPrint)
            {
                Console.WriteLine(num);
            }
        }
    }
}
