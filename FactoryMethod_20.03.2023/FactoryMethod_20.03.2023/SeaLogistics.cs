using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Ship : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Ship deliver");
        }
    }

    class SeaLogistics
    {
        
        public Transport CreateObject()
        {
            return new Ship();
        }
    }
}
