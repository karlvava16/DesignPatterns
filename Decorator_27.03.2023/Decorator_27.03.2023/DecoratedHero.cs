using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{


    public class HumanWarrior : HeroDecorator
    {
        public HumanWarrior(Human comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Человек-воин";
            component.Damage += 20;
            component.Speed += 10;
            component.Health += 50;
            component.Protect += 20;
        }
    }
    public class Swordsman : HeroDecorator
    {
        public Swordsman(HumanWarrior comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Меченосец";
            component.Damage += 40;
            component.Speed -= 10;
            component.Health += 50;
            component.Protect += 40;
        }
    }
    public class Archer : HeroDecorator
    {
        public Archer(HumanWarrior comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Лучник";
            component.Damage += 20;
            component.Speed += 20;
            component.Health += 50;
            component.Protect += 10;
        }
    }
    public class Rider : HeroDecorator
    {
        public Rider(Swordsman comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Всандик";
            component.Damage -= 10;
            component.Speed += 40;
            component.Health += 200;
            component.Protect += 100;
        }
    }
    public class ElfWarrior : HeroDecorator
    {
        public ElfWarrior(Elf comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Эльф-воин";
            component.Damage += 20;
            component.Speed -= 10;
            component.Health += 100;
            component.Protect += 20;
        }
    }
    public class ElfWizard : HeroDecorator
    {
        public ElfWizard(Elf comp) : base(comp) { }
        public override void Change()
        {
            component.Name = "Эльф-воин";
            component.Damage += 10;
            component.Speed += 10;
            component.Health -= 50;
            component.Protect += 10;
        }
    }
}
