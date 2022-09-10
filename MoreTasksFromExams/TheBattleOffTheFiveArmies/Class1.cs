using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleOffTheFiveArmies
{
    internal class Class1
    {
        static void Main()
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] inputMatrix = Console.ReadLine().ToArray();
                if (inputMatrix.Contains('A'))
                {
                    for (int i = 0; i < inputMatrix.Length; i++)
                    {
                        if (inputMatrix[i] == 'A')
                        {
                            inputMatrix[i] = '-';
                            break;
                        }

                    }
                }

                for (int col = 0; col < n; col++)
                {

                    matrix[row, col] = inputMatrix[col];


                }
            }

            string command = "";
            bool isReached = false;
            int saveRow = 0;
            int saveCol = 0;

            while (armor != 0 || isReached == true)
            {
                command = Console.ReadLine();
                string[] array = command.Split(' ');
                int row = int.Parse(array[1]);
                int col = int.Parse(array[2]);

               
                if (array[0] == "up" || array[0] == "down" || array[0] == "left" || array[0] == "right")
                {
                  
                    if (row >= 0 && row < n && col >= 0 && col < n)
                    {
                        if (matrix[row, col] == 'O')
                        {
                            armor -= 2;
                            matrix[row, col] = '-';
                        }
                        else if (matrix[row, col] == 'M')
                        {
                            isReached = true;
                        }
                        else
                        {
                            armor -= 1;
                            matrix[row, col] = '-';
                        }
                    }
                    else
                    {
                        armor--;
                    }

                }
                saveRow = row;
            }
    





        }
    }
}
