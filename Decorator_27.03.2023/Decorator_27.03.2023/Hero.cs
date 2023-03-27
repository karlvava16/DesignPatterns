using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int Protect { get; set; }

        
    }
}
