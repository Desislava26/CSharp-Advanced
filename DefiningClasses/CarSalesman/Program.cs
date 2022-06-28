using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Program
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string displacement = "n/a";
            string efficiency = "n/a";
            List<string> check = new List<string>();
            int res = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();
                string modelEngin = arr[0];
                int powerEngin = int.Parse(arr[1]);

                if (arr.Length == 4)
                {
                        displacement = arr[2];

                    efficiency = arr[3];
                }
                if (arr.Length == 3)
                {
                    if (int.TryParse(arr[2], out res))
                    {
                        displacement = arr[2];

                    }
                    else
                    {
                        efficiency = arr[2];
                    }

                    //displacement = arr[2];
                }
                
                Engine engine = new Engine(modelEngin, powerEngin, displacement, efficiency);
                engines.Add(engine);
            }
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = arr[0];
                string wordEngine = arr[1];
                string weight = "n/a";
                string color = "n/a";
                if (arr.Length == 4)
                {
                    weight = arr[2];
                    color = arr[3];
                }

                bool isIt = false;

                if (arr.Length == 3)
                {
                    //foreach (Engine item in engines)
                    //{
                    //    if (item.Model == arr[1])
                    //    {
                    //        weight = arr[2];
                    //        isIt = true;
                    //        break;
                    //    }
                    //}

                    if (int.TryParse(arr[2], out res))
                    {
                        weight = arr[2];

                    }
                    else
                    {
                        weight = "n/a";
                        color = arr[2];
                    }

                    //weight = arr[2];
                    //if(isIt == false)
                    // {
                    //     color = arr[2];
                    // }
                }
           




                foreach (Engine item in engines)
                {
                    if(item.Model == wordEngine)
                    {
                        Car car = new Car(model, item, weight, color);
                        cars.Add(car);
                    }
                }
               

            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");
                Console.WriteLine($"    Power: {item.Engine.Power}");
                Console.WriteLine($"    Displacement: {item.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {item.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {item.Weight}");
                Console.WriteLine($"  Color: {item.Color}");

            }
            





        }
    }
}
//1
//V8 - 101 220 50
//1
//FordMustang V8-101
