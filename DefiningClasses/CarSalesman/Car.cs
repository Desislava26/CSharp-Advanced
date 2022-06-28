using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    internal class Car
    {
        private string weight = "n/a";
        private string color = "n/a";
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Color

        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            this.weight = weight;
            this.color = color;

        }
    }
}
