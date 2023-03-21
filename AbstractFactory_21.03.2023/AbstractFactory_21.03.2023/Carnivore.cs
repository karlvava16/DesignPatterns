using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Абстрактный класс хищника
    abstract class Carnivore
    {
        public int Power { get; set; }
        public bool IsAlive { get; set; }

        public abstract void Eat(Herbivore herbivore); // метод поедания травоядного животного
    }


}
