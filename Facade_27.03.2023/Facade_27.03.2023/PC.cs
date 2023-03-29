using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PC
    {
        protected CPU cpu { set; get; }
        protected GPU gpu { set; get; }
        protected SSD ssd { set; get; }
        protected MotherBoard mb { set; get; }
        protected PowerSupply ps { set; get; }

        public PC(CPU cpu, GPU gpu, SSD ssd, MotherBoard mb, PowerSupply ps)
        {
            this.cpu = cpu;
            this.gpu = gpu;
            this.ssd = ssd;
            this.mb = mb;
            this.ps = ps;
        }

        public void Start()
        {
            if (cpu == null)
                throw new Exception("There is no CPU");
            if (gpu == null)
                throw new Exception("There is no GPU");
            if (ssd == null)
                throw new Exception("There is no SSD");
            if (mb == null)
                throw new Exception("There is no MotherBoard");
            if (ps == null)
                throw new Exception("There is no PowerSupply");

            Console.WriteLine("|Start PC|");
            ps.Start();
            mb.Start();
            cpu.Start();
            gpu.Start();
            ssd.Start();
        }
        public void Stop()
        {
            Console.WriteLine("|Stop PC|");
            ssd.Stop();
            gpu.Stop();
            cpu.Stop();
            mb.Stop();
            ps.Stop();
        }
    }

    

    public class CPU
    { 
        public string Name { get; set; }
        public CPU() => Name = "Default CPU";
        public CPU(string name) => Name = name;

        public void Start() => Console.WriteLine("Start CPU");
        public void Stop() => Console.WriteLine("Stop CPU");
    };

    public class GPU
    {
        public string Name { get; set; }
        public GPU() => Name = "Default CPU";
        public GPU(string name) => Name = name;

        public void Start() => Console.WriteLine("Start GPU");
        public void Stop() => Console.WriteLine("Stop GPU");
    };

    public class SSD
    {
        public string Name { get; set; }
        public SSD() => Name = "Default SSD";
        public SSD(string name) => Name = name;

        public void Start() => Console.WriteLine("Start SSD");
        public void Stop() => Console.WriteLine("Stop SSD");
    };

    public class RAM
    {
        public string Name { get; set; }
        public RAM() => Name = "Default RAM";
        public RAM(string name) => Name = name;

        public void Start() => Console.WriteLine("Start RAM");
        public void Stop() => Console.WriteLine("Stop RAM");
    };

    public class MotherBoard
    {
        public string Name { get; set; }
        public MotherBoard() => Name = "Default MotherBoard";
        public MotherBoard(string name) => Name = name;

        public void Start() => Console.WriteLine("Start MotherBoard");
        public void Stop() => Console.WriteLine("Stop MotherBoard");
    };

    public class PowerSupply
    {
        public string Name { get; set; }
        public PowerSupply() => Name = "Default PowerSupply";
        public PowerSupply(string name) => Name = name;

        public void Start() => Console.WriteLine("Start PowerSupply");
        public void Stop() => Console.WriteLine("Stop PowerSupply");
    };
}
