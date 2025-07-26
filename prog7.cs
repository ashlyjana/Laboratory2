using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        //ask user for the size of the matrix
        Console.Write("Enter the size of the matrix (must be 3 and above)");
        int size = int.Parse(Console.ReadLine());

        if (size < 3)
        {
            Console.WriteLine("Must be at least 3 by 3 in size.");
            return;
        }

        //2d array for storing the matrix value
        int[,] matrix = new int[size, size];

        //prompt user to input the matrix value row by row
        Console.WriteLine("Enter the matrix values row by row (use space for seperation):");
        for (int row = 0; row < size; row++)
        {
            string[] inputValues = Console.ReadLine().Split(' ');

            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = int.Parse(inputValues[col]);
            }
        }

        //variables for storing the matrox value
        int left2right = 0;
        int right2left = 0;

        // adds both diagonals
        for (int i = 0; i < size; i++)
        {
            left2right += matrix[i, i]; // top-left to bottom-right diagonal
            right2left+= matrix[i, size - 1 - i]; // top-right to bottom-left diagnal
        }

        // calculate the difference between the two diagonal
        int difference = Math.Abs(left2right - right2left);

        //this prints the result
        Console.WriteLine("The result is: " + difference);
    }
}
