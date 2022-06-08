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
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] arrey = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arrey[col];

                }

            }
            int sum = 0;
            for (int row = 0; row < n; row++)
            {

                for (int col = row; col < n; col++)
                {

                    sum += matrix[row, col];
                    break;

                }

            }
            int sumTwo = 0;
            for (int row = 0; row < n; row++)
            {

                for (int col = n - 1; col >= 0; col--)
                {

                    sumTwo += matrix[row, col];
                    row++;

                }
                break;
            }
            int total = Math.Abs(sum - sumTwo);
            Console.WriteLine(total);


        }
    }
}
