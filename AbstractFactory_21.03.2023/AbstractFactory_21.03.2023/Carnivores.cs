using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Хищник - Лев
    class Lion : Carnivore
    {
        public Lion()
        {
            Power = 100;
            IsAlive = true;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (Power > herbivore.Weight)
            {
                Power += 10; // увеличиваем силу после питания
                herbivore.IsAlive = false; // убиваем травоядное животное
            }
            else
            {
                Power -= 10; // уменьшаем силу после неудачной охоты
            }
        }
    }

    // Хищник - Волк
    class Wolf : Carnivore
    {
        public Wolf()
        {
            Power = 50;
            IsAlive = true;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (Power > herbivore.Weight)
            {
                Power += 10; // увеличиваем силу после питания
                herbivore.IsAlive = false; // убиваем травоядное животное
            }
            else
            {
                Power -= 10; // уменьшаем силу после неудачной охоты
            }
        }
    }
}
