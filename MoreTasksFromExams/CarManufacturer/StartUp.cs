using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            //Car c = new Car();
            //Console.WriteLine(c.WhoAmI());
            //Console.WriteLine();

            //Car shkoda = new Car("Shkoda", "Felicia", 1999);
            //Console.WriteLine(shkoda.WhoAmI());
            //Console.WriteLine();

            //Car car = new Car();
            //car.Make = "BMW";
            //car.Model = "X6";
            //car.Year = 2022;
            //car.FuelQuantity = 50;
            //car.FuelConsumption = 0.07;

            //Car anotherCar = new Car()
            //{
            //    Make = "Toyota",
            //    Model = "Avensis",
            //    Year = 2018,
            //    FuelQuantity = 40,
            //    FuelConsumption = 0.08
            //};
            //Console.WriteLine(anotherCar.WhoAmI());
            //Console.WriteLine();

            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine();

            //car.Drive(700);
            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine();

            //car.Drive(50);
            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine();


            //Engine.Run();

            //Engine lamboEngine = new Engine(560, 6300);

            //Tire[] lamboTires = new Tire[] {
            //    new Tire(2018, 2.4),
            //    new Tire(2018, 2.3),
            //    new Tire(2018, 2.4),
            //    new Tire(2018, 2.5),
            //};

            //Car lambo = new Car("Lambo", "Urus", 2010, 250, 0.12, lamboEngine, lamboTires);
            //lambo.Drive(50);
            //Console.WriteLine(lambo.WhoAmI());
            //Console.WriteLine();

            string command; 
            List<Tire> tires = new List<Tire>();
            while ((command = Console.ReadLine()) != "No more tires")
            {
                double[] array = command.Split().Select(double.Parse).ToArray();
                for (int i = 0; i < array.Length; i+=2)
                {
                    int year = Convert.ToInt32(array[i]);
                    double pressure = array[i+1];
                    tires.Add(new Tire(year, pressure));
                }
            }

            List<Engine> engines = new List<Engine>();
            while ((command = Console.ReadLine()) != "Engines done")
            {
                double[] array = command.Split().Select(double.Parse).ToArray();
                for (int i = 0; i < array.Length; i += 2)
                {
                    int horsePower = Convert.ToInt32(array[i]);
                    double cubicCapacity = array[i + 1];
                    engines.Add(new Engine(horsePower, cubicCapacity));
                }
            }

            List<Car> cars = new List<Car>(); 
            List<Engine> engines2 = new List<Engine>();
            List<Tire> tires2 = new List<Tire>();   
            while ((command = Console.ReadLine()) != "Show Special")
            {
                string make = command.Split()[0];
                string model = command.Split()[1];
                int year = int.Parse(command.Split()[2]);
                double fuelQuantity = double.Parse(command.Split()[3]);
                double fuelConsumption = double.Parse(command.Split()[4]);
                int engineIndex = int.Parse(command.Split()[5]);
                int tireIndex = int.Parse(command.Split()[6]);

                //Car car = new Car(make, model, year, fuelQuantity, fuelConsumption);
                Engine horsePower = engines[engineIndex];
                int engin = horsePower.HorsePower;
                Tire tire = tires[tireIndex];
               
                double press = tire.Pressure;
                int sumPress = Convert.ToInt32(press);
                //double distance = car.Drive(20);
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption);
                car.Drive(20);

             

                if(car.Year >= 2017 && engin > 330 && sumPress <=10 && sumPress >=9 )
                {
                    cars.Add(car);
                    engines2.Add(horsePower);
                    

                }



            }




            }
    }
}
