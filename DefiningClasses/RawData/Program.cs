
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split().ToArray();
                string model = array[0];
                int speed = int.Parse(array[1]);
                int power = int.Parse(array[2]);
                Engine engine = new Engine(speed, power);
                int weight = int.Parse(array[3]);
                string type = array[4];
                Cargo cargo = new Cargo(type, weight);
                int age1 = int.Parse(array[6]); 
                double pressure1 = double.Parse(array[5]); 
                    int age2 = int.Parse(array[8]);
                    double pressure2 = double.Parse(array[7]);
                    int age3=   int.Parse(array[10]);
                    double pressure3 = double.Parse(array[9]);
                    int age4 = int.Parse(array[12]);
                    double pressure4 = double.Parse(array[11]);
                Tires tires = new Tires(age1,pressure1, age2, pressure2, age3,pressure3,age4,pressure4);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }
            string word = Console.ReadLine();
            List<string> models = new List<string>();

            foreach(Car item in cars)
            {
                if(item.Cargo.Type == "fragile" && word == "fragile")
                {
                    if(item.Tires.Pressure1 < 1 || item.Tires.Pressure2 < 1 || item.Tires.Pressure3 < 1 || item.Tires.Pressure4 < 1)
                    {
                        models.Add(item.Model);
                    }
                }
                else if(item.Cargo.Type == "flammable" && word =="flammable"&& item.Engine.Power > 250)
                {
                    models.Add(item.Model);
                }
            }
            foreach (var item in models)
            {
                Console.WriteLine(item);
            }

        }
    }
}
