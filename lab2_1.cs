using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare two arrays
            string[] names = new string[10];
            int[] scores = new int[10];

            // Input 10 student names and scores
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter name: ");// input for name
                names[i] = Console.ReadLine(); // Read name input

                Console.Write("Enter score: "); // input for score
                scores[i] = int.Parse(Console.ReadLine()); // Read score input
            }

            // for loop 
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (scores[j] > scores[i] || 
                        (scores[j] == scores[i] && names[j].CompareTo(names[i]) < 0))
                    {
                        // Swap scores
                        int tempScore = scores[i];
                        scores[i] = scores[j];
                        scores[j] = tempScore;

                        // Swap names
                        string tempName = names[i];
                        names[i] = names[j];
                        names[j] = tempName;
                    }
                }
            }

            // Display Top 3 students after sorting is done
            Console.WriteLine("\nTop 3 Students:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Rank {i + 1}. {names[i]} - {scores[i]}");
            }
        }
    }
}
