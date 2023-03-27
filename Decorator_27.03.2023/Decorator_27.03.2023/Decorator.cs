using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero component { get; set; }
        public HeroDecorator(Hero component) => this.component = component;
        public abstract void Change();
    }
}
