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
            
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = "";
            string[] arrey = new string[4];
            

            string[,] matrix = new string[input[0], input[1]];


            for (int row = 0; row < input[0]; row++)
            {
                arrey = Console.ReadLine().Split(" ").ToArray();
                
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = arrey[col];

                }
            

            }


            while ((command = Console.ReadLine()) != "END")
            {
                string[] array = command.Split().ToArray();
                if (array[0] == "swap" && array.Length == 5)
                {
                    int first = int.Parse(array[1]);
                    int second = int.Parse(array[2]);
                    int third = int.Parse(array[3]);
                    int fourth = int.Parse(array[4]);
                    if (first > input[0] && second > input[1] && third > input[0] && fourth > input[1])
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string change = matrix[first, second];
                        string changeTwo = matrix[third, fourth];
                        matrix[first, second] = changeTwo;
                        matrix[third, fourth] = change;
                        for (int i = 0; i < input[0]; i++)
                        {
                            for (int j = 0; j < input[1]; j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }



            }


        }
    }
}
