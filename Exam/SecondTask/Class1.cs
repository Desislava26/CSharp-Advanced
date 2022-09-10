using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Class1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int saveRow = 0;
            int saveCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] inputMatrix = Console.ReadLine().ToArray();

                for (int col = 0; col < n; col++)
                {
                    if (inputMatrix[col] == 'V')
                    {
                        saveCol = col;
                        saveRow = row;
                        matrix[row, col] = '*';
                    }
                    else
                    {


                        matrix[row, col] = inputMatrix[col];
                    }
                }
            }
            int countHoles = 1;
            bool notRead = false;
            int hit = 0;
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
           
                if (command == "up")
                {
                    if (saveRow-1 >= 0 && saveRow-1 < n && saveCol >= 0 && saveCol < n)
                    {
                        saveRow--;
                        if (matrix[saveRow, saveCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hit++;
                            saveRow++;
                            continue;
                        }
                        else if (matrix[saveRow, saveCol] == 'C')
                        {
                            matrix[saveRow, saveCol] = 'E';
                            countHoles++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
                            notRead = true;
                            break;
                        }
                        else if (matrix[saveRow, saveCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{saveRow}, {saveCol}]!");
                        }
                        else
                        {
                            matrix[saveRow, saveCol] = '*';
                            countHoles++;
                         
                        }

                    }


                }
                else if (command == "down")
                {
                    if (saveRow+1 >= 0 && saveRow+1 < n && saveCol >= 0 && saveCol < n)
                    {
                        saveRow++;
                        if (matrix[saveRow, saveCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hit++;
                            saveRow--;
                            
                            continue;
                        }
                        else if (matrix[saveRow, saveCol] == 'C')
                        {
                            matrix[saveRow, saveCol] = 'E';
                            countHoles++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
                            notRead=true;
                          
                            break;
                        }
                        else if (matrix[saveRow, saveCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{saveRow}, {saveCol}]!");
                        }
                        else
                        {
                            matrix[saveRow, saveCol] = '*';
                            countHoles++;
                         
                        }

                    }

                }

                else if (command == "left")
                {
                    if (saveRow >= 0 && saveRow < n && saveCol-1 >= 0 && saveCol-1 < n)
                    {
                        saveCol--;
                        if (matrix[saveRow, saveCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hit++;
                            saveCol++;
                            continue;
                        }
                        else if (matrix[saveRow, saveCol] == 'C')
                        {
                            matrix[saveRow, saveCol] = 'E';
                            countHoles++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
                            notRead =true;
                            break;
                        }
                        else if (matrix[saveRow, saveCol] == '*' || matrix[saveRow, saveCol] == 'V' )
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{saveRow}, {saveCol}]!");
                        }
                        else
                        {
                            matrix[saveRow, saveCol] = '*';
                            countHoles++;
                       
                        }

                    }


                }

                else if (command == "right")
                {
                    if (saveRow >= 0 && saveRow < n && saveCol+1 >= 0 && saveCol+1 < n)
                    {
                        saveCol++;
                        if (matrix[saveRow, saveCol] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hit++;
                            saveCol--;
                            continue;
                        }
                        else if (matrix[saveRow, saveCol] == 'C')
                        {
                            matrix[saveRow, saveCol] = 'E';
                            countHoles++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
                            notRead=true;
                            break;
                        }
                        else if (matrix[saveRow, saveCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{saveRow}, {saveCol}]!");
                        }
                        else
                        {
                            matrix[saveRow, saveCol] = '*';
                            countHoles++;
                          
                        }

                    }


                }



            }

            if(notRead == false)
            {
                Console.WriteLine($"Vanko managed to make {countHoles} hole(s) and he hit only {hit} rod(s).");
                matrix[saveRow, saveCol] = 'V';
            }

    
            List<char> list = new List<char>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    list.Add(matrix[i, j]);
                }
                Console.WriteLine(string.Join("", list));
                list.Clear();
            }


        }
    }
}
