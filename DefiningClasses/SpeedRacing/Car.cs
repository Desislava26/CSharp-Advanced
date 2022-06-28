using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptinPerKilometer;
        private double travelledDistance = 0;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptinPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptinPerKilometer = fuelConsumptionFor1km;
            TravelledDistance = travelledDistance;

        }


    }
}
