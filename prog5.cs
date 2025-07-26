using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to shift elements of an array by k positions
            int[] arr = new int[10];
            int[] shifted = new int[10];

            // Input: 10 integers
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Input: value of k
            Console.Write("\nEnter value of k (shifts): ");
            int k = int.Parse(Console.ReadLine());

            // Handle k > array length
            k = k % 10;

            for (int i = 0; i < 10; i++)//for loop
            {
                shifted[(i + k) % 10] = arr[i];
            }

            // Display original array
            Console.WriteLine("\nOriginal Array:");
            foreach (int num in arr)
                Console.Write(num + " ");

            // Display shifted array
            Console.WriteLine("\nShifted Array:");
            foreach (int num in shifted)
                Console.Write(num + " ");
        }
    }
}
