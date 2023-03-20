using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class RoadLogistics
    {
        class Truck : Transport
        {
            public void deliver()
            {
                Console.WriteLine("Truck deliver");
            }
        }

        public Transport CreateTruck()
        {
            return new Truck();
        }
    }
}
