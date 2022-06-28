using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        private string displacement = "n/a";
        private string efficiency = "n/a";
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement
        {
            get
            {
                return displacement;
            }
            set
            {
                displacement = value;
            }
        }
        public string Efficiency

        {
            get
            {
                return efficiency;
            }
            set
            {
                efficiency= value;
            }
        }

        public Engine(string modelEngin, int powerEngin, string displacement, string efficiency)
        {
            Model = modelEngin;
            Power = powerEngin;
            this.displacement = displacement;
            this.efficiency = efficiency;

        }
        //public Engine(string modelEngin, int powerEngin)
        //{
        //    Model = modelEngin;
        //    Power = powerEngin;
        //    Displacement = displacement;
        //    Efficiency = efficiency;

        //}
       



    }
}
