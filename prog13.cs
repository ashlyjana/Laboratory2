using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store 10 durations in seconds
            int[] durationsInSeconds = new int[10];

            // Ask the user to enter 10 durations
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter duration in seconds (" + (i + 1) + "/10): ");
                durationsInSeconds[i] = int.Parse(Console.ReadLine());
            }

            // Print table header
            Console.WriteLine();
            Console.WriteLine("Seconds\t\tHours : Minutes : Seconds");

            // Convert each duration to HH:MM:SS format
            for (int i = 0; i < 10; i++)
            {
                int totalSeconds = durationsInSeconds[i];

                int hours = totalSeconds / 3600;
                int remainingSecondsAfterHours = totalSeconds % 3600;

                int minutes = remainingSecondsAfterHours / 60;
                int seconds = remainingSecondsAfterHours % 60;

                // Display the result
                Console.WriteLine(totalSeconds + "\t\t" + hours + " : " + minutes + " : " + seconds);
            }

        }
    }
}
