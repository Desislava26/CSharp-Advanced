using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();
                string model = arr[0];
                int fuelAmount = int.Parse(arr[1]);
                double fuelConsumptionFor1km = double.Parse(arr[2]);
                double travelledDistance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, travelledDistance);
                cars.Add(car);

            }
            string command;
            //amount of km * fuel1km 
            while ((command = Console.ReadLine()) != "End")
            {
                string[] array = command.Split().ToArray();
                string model = array[1];
                int amountOfKm = int.Parse(array[2]);
                foreach (Car car in cars)
                {
                    if(car.Model == model)
                    {
                        double result = car.FuelAmount - (amountOfKm * car.FuelConsumptinPerKilometer);
                        if (result >=0)
                        {
                            car.FuelAmount -= (amountOfKm * car.FuelConsumptinPerKilometer);
                            car.TravelledDistance += amountOfKm;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                    }
                }


            }
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }



        }

    }
}
