using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldFactory field = new FieldFactory();
            field.Show(new LightSoldiers(), 3, 4);

            field.Show(new LightSoldiers(), 5, 6);

            field.Show(new AirTransport(), 4, 4);

            //field.ShowAll();


        }
    }
}
