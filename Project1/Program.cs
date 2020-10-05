/// Homework 5		Project 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  October 5, 2020
///
/// Problem Statement: Write code to creat a copy of an array.
/// 
/// 
/// Overall Plan:
/// 1) Create initial array with 10 items
/// 2) Assign values to the array
/// 3) Create a second array empty array of the same length
/// 4) Use a loop to copy values from the first array into the second
/// 5) Print out both arrays
///

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create initial array and assign values to the 10 items in the array
            int[] firstArray = new int[10] { 5, 9, 0, 7, 12, 45, 23, 2, 16, 89 };

            // create second empty array
            int[] secondArray = new int[firstArray.Length];

            // assign the values from the first array to elements in the second array
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            // print out both arrays
            Console.WriteLine("First Array: ");
            Console.WriteLine(string.Join("\n", firstArray));
            Console.WriteLine("\nSecond Array: ");
            Console.WriteLine(string.Join("\n", secondArray));
           
        }
    }
}
