using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this program reads 10 integers from the user, then reads a mathematical expression
            int[] number = new int[10], res = new int[10];

            for (int i = 0; i < 10; i++)//for loop
            {
                Console.Write($"Number {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Expression (use x): ");
            string expr = Console.ReadLine();

            for (int i = 0; i < 10; i++)//for loop
            {
                string e = expr.Replace("x", number[i].ToString());
                res[i] = Convert.ToInt32(new DataTable().Compute(e, null));
            }

            Console.WriteLine("\nOriginal\tResult");
            for (int i = 0; i < 10; i++)//for loop
                Console.WriteLine($"{number[i]}\t\t{res[i]}");
        }
    }
}
