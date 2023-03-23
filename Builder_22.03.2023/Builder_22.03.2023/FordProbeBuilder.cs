using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FordProbeBuilder : ICarBuilder
    {
        Car product;
        public FordProbeBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            product = new Car();
        }
        public void BuildName()
        {
            product.Name = "Ford Probe";
        }
        public void BuildCase()
        {
            product.Case = "Купе";
        }
        public void BuildEngene()
        {
            product.Engene = 160;
        }
        public void BuildGearBox()
        {
            product.GearBox = "4 Auto";
        }
        public void BuildWheels()
        {
            product.WheelsRadius = 14;
        }
        public Car GetCar()
        {
            Car car = product;
            Reset();
            return car;
        }

    }
}
