using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Truck : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Truck deliver");
        }
    }

    class RoadLogistics
    {
        

        public Transport CreateObject()
        {
            return new Truck();
        }
    }
}
