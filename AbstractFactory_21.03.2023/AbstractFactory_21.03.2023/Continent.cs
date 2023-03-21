using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Абстрактная фабрика континента
    abstract class Continent
    {
        public abstract Herbivore CreateHerbivore(); // метод создания травоядного животного
        public abstract Carnivore CreateCarnivore(); // метод создания хищника
    }
}
