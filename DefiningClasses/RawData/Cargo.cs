using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        public string Type { get; set; }
        public double Weight { get; set; }

        public Cargo(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }
    }
}
