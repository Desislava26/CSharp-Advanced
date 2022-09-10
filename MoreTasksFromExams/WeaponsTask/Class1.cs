using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {

        static void Main()
        {
          List<int>steel = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Queue<int> queue = new Queue<int>(steel);
            List<int>carbon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

          Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> swords = new Dictionary<string, int>();
            dict["Gladius"] = 70;
            dict["Shamshir"] = 80;
            dict["Katana"] = 90;
            dict["Sabre"] = 110;
            dict["Broadsword"] = 150;

            Stack<int> stack = new Stack<int>(carbon);

                while(stack.Count != 0 && queue.Count != 0) 
               { 
                int item = queue.Peek();
                int carb = stack.Peek();
                

                if (dict.ContainsValue(item + carb))
                    {
                      
                        var myKey = dict.FirstOrDefault(x => x.Value == item + carb).Key;
                        if (!swords.ContainsKey(myKey))
                        {
                            swords.Add(myKey, 1);
                        }
                        else
                        {
                            swords[myKey] ++;
                        }
              
                    queue.Dequeue();
                    stack.Pop();
                }
                    else
                    {
                
                    queue.Dequeue();
                    stack.Pop();
                    carb = carb+ 5;
                        stack.Push(carb);
                  
                    }
                    

                }
            
            bool isAny = false;
            if(swords.Count == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
                isAny = true;
            }
            else
            {
                int sum = swords.Values.Sum();
                Console.WriteLine($"You have forged {sum} swords.");
            }
            if(queue.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",queue)}");
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", stack)}");
            }
            if (!isAny)
            {
                foreach (var item in swords.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }


        }


    }
}
