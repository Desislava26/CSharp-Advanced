using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truffle_hunter
{
    internal class Class1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];
           
            int blackCount = 0;
            int summerCount = 0;
            int whiteCount = 0;
            int wildCount = 0;
            
            for (int row = 0; row < n; row++)
            {
                string[] inputMatrix = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = inputMatrix[col].ToString();
                }
            }
       
            string command = "";
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] array = command.Split(' ');
                if (array[0] == "Collect")
                {
                    int row = int.Parse(array[1]);
                    int col = int.Parse(array[2]);
                    if (row >= 0 && row < n && col >= 0 && col < n)
                    {
                        string getChar = matrix[row, col];
                        if (getChar == "B")
                        {
                            blackCount++;
                        }
                        else if (getChar == "S")
                        {
                            summerCount++;
                        }
                        else if (getChar == "W")
                        {
                            whiteCount++;
                        }
                        matrix[row, col] = "-";
                    }
              
                 }
                if (array[0] == "Wild_Boar")
                {
                    int row1 = int.Parse(array[1]);
                    int col1 = int.Parse(array[2]);
                    string direction = array[3];
                    if (row1 >= 0 && row1 < n && col1 >= 0 && col1 < n)
                    {
                        string getChar = matrix[row1, col1];
                        if (getChar != "-")
                        {
                            wildCount++;
                            matrix[row1, col1] = "-";
                        }
                        if (direction == "up")
                        {
                            while (row1 >= 0)
                            {
                                if (row1 >= 0)
                                {
                                    getChar = matrix[row1, col1];
                                    if (getChar != "-")
                                    {
                                        wildCount++;
                                        matrix[row1, col1] = "-";
                                       
                                    }
                                }
                                row1 -= 2;
                               
                            }


                        }
                        if (direction == "right")
                        {
                            while (col1 < n)
                            {

                                if (col1 < n)
                                {
                                    getChar = matrix[row1, col1];
                                    if (getChar != "-")
                                    {
                                        wildCount++;
                                        matrix[row1 , col1 ] = "-";
                                       
                                    }
                                }
                            
                                col1 += 2;
                            }


                        }
                        if (direction == "left")
                        {
                            while (col1 >= 0)
                            {

                                if (col1 >= 0)
                                {
                                    getChar = matrix[row1, col1];
                                    if (getChar != "-")
                                    {
                                        wildCount++;
                                        matrix[row1, col1] = "-";
                                       
                                    }
                                }
                             
                                col1 -= 2;
                            }


                        }
                        if (direction == "down")
                        {
                            while (row1 < n)
                            {
                                if (row1 < n)
                                {
                                    getChar = matrix[row1, col1];
                                    if (getChar != "-")
                                    {
                                        wildCount++;
                                        matrix[row1, col1] = "-";
                                       
                                    }
                                }
                                row1 += 2;
                           
                            }


                        }


                    }


                }

            }

            Console.WriteLine($"Peter manages to harvest {blackCount} black, {summerCount} summer, and {whiteCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildCount} truffles.");
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    list.Add(matrix[i, j]);
                }
                Console.WriteLine(string.Join(" ", list));
                list.Clear();
            }


        }
    }
}
