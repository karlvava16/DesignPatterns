using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DaewooLanosBuilder : ICarBuilder
    {
        Car product;
        public DaewooLanosBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            product = new Car();
        }
        public void BuildName()
        {
            product.Name = "Daewoo Lanos";
        }
        public void BuildCase()
        {
            product.Case = "Седан";
        }
        public void BuildEngene()
        {
            product.Engene = 98;
        }
        public void BuildGearBox()
        {
            product.GearBox = "5 Manual";
        }
        public void BuildWheels()
        {
            product.WheelsRadius = 13;
        }
        public Car GetCar()
        {
            Car car = product;
            Reset();
            return car;
        }

    }
}
