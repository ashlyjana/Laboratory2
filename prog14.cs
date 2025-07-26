using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to store zip codes and their counts
            Dictionary<string, int> zipCounts = new Dictionary<string, int>();

            // Ask user to input 25 zip codes
            for (int i = 1; i <= 25; i++)
            {
                Console.Write("Enter zip code (" + i + "/25): ");
                string zip = Console.ReadLine();

                // Convert to standard format (optional: uppercase, trim)
                zip = zip.Trim();

                // Count frequency
                if (zipCounts.ContainsKey(zip))
                {
                    zipCounts[zip] = zipCounts[zip] + 1;
                }
                else
                {
                    zipCounts[zip] = 1;
                }
            }

            // Create a list to sort the dictionary entries
            List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>(zipCounts);

            
            sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            // Display result
            Console.WriteLine("\nZIP Code\tFrequency");

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList[i].Key + "\t\t" + sortedList[i].Value);
            }
        }
    }
}
