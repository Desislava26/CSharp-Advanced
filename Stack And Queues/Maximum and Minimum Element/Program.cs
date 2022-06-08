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
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (command.Length == 1)
                {
                    if (command[0] == 2)
                    {
                        stack.Pop();
                    }
                    else if (command[0] == 3 && stack.Count != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (command[0] == 4 && stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else if (command.Length == 2)
                {
                    stack.Push(command[1]);
                }
            }

           
            Console.WriteLine($"{string.Join(", ", stack)}");
            



        }



    }
}
