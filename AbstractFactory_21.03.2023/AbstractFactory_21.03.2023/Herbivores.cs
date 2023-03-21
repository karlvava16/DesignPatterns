using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    // Травоядное животное - Антилопа Гну
    class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            Weight = 100;
            IsAlive = true;
        }

        public override void EatGrass()
        {
            Weight += 10; // увеличиваем вес после кормежки
        }
    }

    // Травоядное животное - Бизон
    class Bison : Herbivore
    {
        public Bison()
        {
            Weight = 150;
            IsAlive = true;
        }

        public override void EatGrass()
        {
            Weight += 10; // увеличиваем вес после кормежки
        }
    }
}
