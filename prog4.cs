using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to calculate the highest gain in stock prices over a week
            float[] price = new float[7];
            float maxGain = 0;
            int day = 1;

            for (int i = 0; i < 7; i++)// for loop
            {
                Console.Write($"Price for Day {i + 1}: ");
                price[i] = float.Parse(Console.ReadLine());
            }
            // Display the prices entered
            Console.WriteLine("\nDay\tGain (%)");
            Console.WriteLine("1\t-");

            for (int i = 1; i < 7; i++) // for loop
            {
                // Calculate the gain percentage
                float gain = ((price[i] - price[i - 1]) / price[i - 1]) * 100;
                Console.WriteLine($"{i + 1}\t{gain:F2}%");
                // Check if this gain is the highest
                if (gain > maxGain)
                {
                    maxGain = gain;
                    day = i + 1;
                }
            }
            // Display the highest gain 
            Console.WriteLine($"\nHighest gain: Day {day} ({maxGain:F2}%)");
        }
    }
}
