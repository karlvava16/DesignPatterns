using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ICarBuilder
    {
        void Reset();
        void BuildName();
        void BuildCase();
        void BuildEngene();
        void BuildWheels();
        void BuildGearBox();
        Car GetCar();
    }
}
