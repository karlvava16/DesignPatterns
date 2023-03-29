using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC(new CPU(), new GPU(), new SSD(), new MotherBoard(), new PowerSupply());
            pc.Start();
            Console.WriteLine();
            pc.Stop();
        }
    }
}
