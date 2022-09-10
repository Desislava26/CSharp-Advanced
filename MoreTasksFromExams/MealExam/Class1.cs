using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealExam
{
    internal class Class1
    {
        static void Main()
        {
            string[] meals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] mealsRev = meals.Reverse().ToArray();
            Stack<string> stack = new Stack<string>();
            

            foreach (string meal in mealsRev)
            {
                stack.Push(meal);
            }
            int [] calories = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 
            int[] caloriesRev = calories.Reverse().ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (int cal in caloriesRev)
            {
                queue.Enqueue(cal);
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["salad"] = 350;
            dict["soup"] = 490;
            dict["pasta"] = 680;
            dict["steak"] = 790;
            int counter = 0;
            bool isItEnough = false;
            int day = queue.Dequeue();
            int resSave = 0;
            List<string> vs = new List<string>();
            vs = stack.ToList() ;
            foreach (string meal in vs)
            {
                stack.Pop();
                vs = stack.ToList();
                counter++;
                int cal = dict[meal];
               
                int res = day - cal;
                if(res >= 0)
                {
                    day = res;

                }
                else
                {
                    if(queue.Count == 0)
                    {
                        Console.WriteLine($"John ate enough, he had {counter} meals.");
                        isItEnough = true;
                        break; 
                    }
                    int next = queue.Dequeue();
                    res = next - Math.Abs(res);
                    day = res;
                    resSave = res;
                }
               
                
                
                
            }
       
            
            if(isItEnough == false)
            {
                Console.WriteLine($"John had {counter} meals.");
                foreach(var cal in queue)
                {

                }
                Console.WriteLine($"For the next few days, he can eat {resSave}, {string.Join(", ", queue)} calories.");
            }
            if (isItEnough)
            {
              
                Console.WriteLine($"Meals left: {string.Join(", ", stack)}.");
            }

        }
    }
}
