using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this calculates the average, minimum, maximum, and counts the number of people in different age brackets
            int[] ages = new int[20];
            int sum = 0, min = int.MaxValue, max = int.MinValue;
            int bracketUnder18 = 0, bracket18to35 = 0, bracket36to60 = 0, bracketAbove60 = 0;

            Console.WriteLine("Enter 20 age responses:"); // inpusts ages from the user

            for (int i = 0; i < 20; i++) //for loop
            {
                Console.Write($"Age {i + 1}: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.Write("Invalid input. Enter a valid non-negative age: "); // input validation
                }
                // Store the age in the array and update statistics
                ages[i] = age;
                sum += age;
                // Update min and max
                if (age < min) min = age;
                if (age > max) max = age;

                // Count age brackets
                if (age < 18)
                    bracketUnder18++;
                else if (age <= 35)
                    bracket18to35++;
                else if (age <= 60)
                    bracket36to60++;
                else
                    bracketAbove60++;
            }
            // Output the results
            double average = (double)sum / 20;
            // clear table (uneven) 
            Console.WriteLine("____________________________");
            Console.WriteLine("Statistics:                 |");           
            Console.WriteLine("___________________________ |");   
            Console.WriteLine($"Total Age Sum: {sum}       |");
            Console.WriteLine("___________________________ |");
            Console.WriteLine($"Average Age: {average:F2}  |");    
            Console.WriteLine($"Minimum Age: {min}         |");
            Console.WriteLine($"Maximum Age: {max}         |");
            Console.WriteLine("____________________________|");
            Console.WriteLine($"Number of people under 18: {bracketUnder18}|");
            Console.WriteLine($"Number of people aged 18 to 35: {bracket18to35}|");
            Console.WriteLine($"Number of people aged 36 to 60: {bracket36to60} |");
            Console.WriteLine($"Number of people above 60: {bracketAbove60} |");
            Console.WriteLine("____________________________|");



        }
    }
}
