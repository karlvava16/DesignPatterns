using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Microwave
    {
        public void StartCooking()
        {
            Console.WriteLine("Start microwave");
        }

        public void StopCooking()
        {
            Console.WriteLine("Stop microwave");
        }
    }
}
