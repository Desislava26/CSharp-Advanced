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
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> stack = new Queue<int>();
            int[] order = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool noOrder = false;
            foreach (var item in order)
            {
                stack.Enqueue(item);
            }
            Console.WriteLine(stack.Max());

            for (int i = 0; i < order.Length; i++)
            {

                int result = quantity -= (order[i]);

                //stack.Dequeue();

                if (result < 0)
                {
                    noOrder = true;
                    break;
                }
                else
                {
                    stack.Dequeue();
                }

            }
            if (noOrder)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", stack)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }



        }



    }
}
