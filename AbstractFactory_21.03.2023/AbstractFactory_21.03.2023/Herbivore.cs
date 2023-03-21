using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Абстрактный класс травоядного животного
    abstract class Herbivore
    {
        public int Weight { get; set; }
        public bool IsAlive { get; set; }

        public abstract void EatGrass(); // метод кормления травой
    }

}
