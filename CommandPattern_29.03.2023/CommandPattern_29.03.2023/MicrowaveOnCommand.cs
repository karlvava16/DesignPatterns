using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CommandPattern
{
    internal class MicrowaveOnCommand : ICommand
    {
        Microwave microwave = new Microwave();
        public float Timer { get; set; }
        public void Execute()
        {
            microwave.StartCooking();
            Console.WriteLine("Cooking...");
            Thread.Sleep((int)(Timer * 1000));
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
