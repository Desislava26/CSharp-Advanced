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
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>();
            StringBuilder sb = new StringBuilder();
            // List<string> list = new List<string>();
            foreach (var item in songs)
            {
                queue.Enqueue(item);
            }


            while (queue.Count != 0)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                if (command[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    List<string> list = new List<string>();
                    foreach (var item in command)
                    {
                        if (item == "Add")
                        {
                            continue;
                        }
                        else
                        {
                            list.Add(item);
                        }
                    }
                    string song = string.Join(" ", list);
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", queue)}");
                }


            }
            Console.WriteLine("No more songs!");



        }



    }
}
