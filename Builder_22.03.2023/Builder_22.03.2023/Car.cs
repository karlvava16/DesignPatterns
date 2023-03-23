using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public string Name { get; set; }
        public string Case { get; set; }
        public int Engene { get; set; }
        public int WheelsRadius { get; set; }
        public string GearBox { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" + $"Case: {Case}\n" + $"Engene: {Engene} л.с\n"
                + $"Wheel Radius: {WheelsRadius}\n" + $"GearBox: {GearBox}\n";
        }
    }
}
