using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenNumbers
{
    internal class test
    {
        static void Main()
        {
           int [] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());

            Func<int, bool> func = x => x;
           
        }
    }
}
