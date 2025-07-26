using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program calculates the sum of numbers in a sliding window of size k
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter window size (k): ");
            int k = int.Parse(Console.ReadLine());

            if (k <= 0 || k > 10)
            {
                Console.WriteLine("Invalid window size.");
                return;
            }

            Console.WriteLine("\nSliding Window Sums:");
            for (int i = 0; i <= 10 - k; i++)
            {
                int sum = 0;
                for (int j = i; j < i + k; j++)
                    sum += numbers[j];

                Console.WriteLine($"Window {i + 1}: {sum}");
            }
        }
    }
}
