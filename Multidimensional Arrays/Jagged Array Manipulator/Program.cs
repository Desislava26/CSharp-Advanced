using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];


            for (int row = 0; row < n; row++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col <= array.Length - 1; col++)
                {
                    matrix[row] = array;

                }

            }

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col <= matrix[row].Length - 1; col++)
                {
                    if (matrix[row].Length == matrix[row + 1].Length)
                    {
                        matrix[row] = matrix[row].Select(el => el * 2).ToArray();
                        matrix[row + 1] = matrix[row + 1].Select(el => el * 2).ToArray();
                    }
                    else
                    {
                        matrix[row] = matrix[row].Select(el => el / 2).ToArray();
                        matrix[row + 1] = matrix[row + 1].Select(el => el / 2).ToArray();
                    }

                    break;
                }

            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] array = command.Split();
                if (array[0] == "Add")
                {
                    int row = int.Parse(array[1]);
                    int col = int.Parse(array[2]);
                    int value = int.Parse(array[3]);
                    if (row < n && row >= 0 && col <= matrix[row].Length - 1 && col >= 0)
                    {
                        matrix[row][col] += value;

                    }
                }
                else if (array[0] == "Subtract")
                {
                    int row = int.Parse(array[1]);
                    int col = int.Parse(array[2]);
                    int value = int.Parse(array[3]);
                    if (row < n && row >= 0 && col <= matrix[row].Length - 1 && col >= 0)
                    {
                        matrix[row][col] -= value;

                    }
                }

            }


            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }


        }
    }
}
