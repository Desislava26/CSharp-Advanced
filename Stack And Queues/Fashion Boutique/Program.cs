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
            var priceOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfARack = int.Parse(Console.ReadLine());

            Stack<int> prices = new Stack<int>(priceOfClothes);

            int sumOfClothes = 0;
            int numOfRacks = 1;

            for (int i = priceOfClothes.Length - 1; i >= 0; i--)
            {
                sumOfClothes += priceOfClothes[i];

                if (sumOfClothes <= capacityOfARack)
                {
                    if (prices.Any())
                    {
                        prices.Pop();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    numOfRacks++;
                    sumOfClothes = 0;
                }
            }



        }



    }
}
