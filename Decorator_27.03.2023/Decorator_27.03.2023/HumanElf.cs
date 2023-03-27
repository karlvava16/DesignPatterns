using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{   
    public class Human : Hero
    {
        Human()
        {
            Name = "Human";
            Damage = 20;
            Speed = 20;
            Health = 150;
            Protect = 0;
        }
    }

    public class Elf : Hero
    {
        Elf()
        {
            Name = "Эльф";
            Damage = 15;
            Speed = 30;
            Health = 100;
            Protect = 0;
        }

    }
}
