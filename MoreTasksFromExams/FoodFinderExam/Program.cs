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
            char[] firstWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            List<string> list = new List<string>
            {"pear",
            "flour",
             "pork",
             "olive"
             };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["pear"] = 0;
            dict["flour"] = 0;
            dict["pork"] = 0;
            dict["olive"] = 0;
          
            Queue<char> queue = new Queue<char>(secondWord.Reverse());
            Queue<char>stackQueue = new Queue<char>(firstWord);

           
            while (queue.Count != 0 && stackQueue.Count != 0)
            {
                char glasna = stackQueue.First();
                char suglasna = queue.First();
                foreach (string word in list)
                {
                    if (word.Contains(glasna))
                    {
                        if (word.Length > dict[word])
                        {
                            dict[word] += 1;
                        }
                    }
                    if (word.Contains(suglasna))
                    {
                        if (word.Length > dict[word])
                        {
                            dict[word] += 1;
                        }
                    }
                    
                }
                stackQueue.Dequeue();
                stackQueue.Enqueue(glasna);
                queue.Dequeue();
            }
            List<string> words = new List<string>();

            foreach (var item in dict)
            {
                if(item.Value >= item.Key.Length)
                {
                    words.Add(item.Key);
                }
            }
            Console.WriteLine($"Words found: {words.Count}");
            foreach(var item in words)
            {
                Console.WriteLine(item);
            }





        }
           
   }
}

