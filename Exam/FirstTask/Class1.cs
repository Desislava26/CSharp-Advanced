using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Class1
    {
        static void Main()
        {
          
            List<int> whiteTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> greyTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();



            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Sink"] = 40;
            dict["Oven"] = 50;
            dict["Countertop"] = 60;
            dict["Wall"] = 70;

            Dictionary<string, int> dictCount = new Dictionary<string, int>();
            dictCount["Sink"] = 0;
            dictCount["Oven"] = 0;
            dictCount["Countertop"] = 0;
            dictCount["Wall"] = 0;
            dictCount["Floor"] = 0;


            while (whiteTiles.Count != 0 && greyTiles.Count != 0)
            {
                int white = whiteTiles.Last();
                int grey = greyTiles.First();
                whiteTiles.RemoveAt(whiteTiles.Count - 1);
                greyTiles.RemoveAt(0);


                if (dict.ContainsValue(white + grey) && white == grey)
                {
                    var myKey = dict.FirstOrDefault(x => x.Value == white + grey).Key;
                    dictCount[myKey] += 1;
                  

                }
                else if (!(dict.ContainsValue(white + grey)) && white == grey)
                {
                    dictCount["Floor"] += 1;
                
                }
                else
                {
                    white = white / 2;
                  
                    whiteTiles.Add(white);
                  
                    greyTiles.Add(grey);
                   
                   

                    
                }
    




            }

            if(whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }

            foreach (var item in dictCount.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Where(x=> x.Value !=0))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }


        }




    }
}
