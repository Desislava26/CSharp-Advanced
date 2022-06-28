using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
        public int Age1 { get; set; }
        public double Pressure1 { get; set; }
        public int Age2 { get; set; }
        public double Pressure2 { get; set; }
        public int Age3 { get; set; }
        public double Pressure3 { get; set; }
        public int Age4 { get; set; }
        public double Pressure4 { get; set; }

        public Tires(int age1, double pressure1, int age2, double pressure2, int age3, double pressure3, int age4, double pressure4)
        {
            Age1 = age1;
            Pressure1 = pressure1;
            Age2 = age2;
            Pressure2 = pressure2;
            Age3 = age3;
                Pressure3 = pressure3;
            Pressure4 = pressure4;
            
        }
    }
}
