using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    

    class SeaLogistics
    {
        class Ship : Transport
        {
            public void deliver()
            {
                Console.WriteLine("Ship deliver");
            }
        }
        public Transport CreateShip()
        {
            return new Ship();
        }
    }
}
