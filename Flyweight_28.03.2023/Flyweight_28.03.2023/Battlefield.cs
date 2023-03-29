using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Flyweight
{
    abstract class Battlefield
    {

        public string pic { get; set; }

        public int speed { get; set; }

        public int power { get; set; }


        public int x { get; set; }

        public int y { get; set; }


        abstract public void Show(int x, int y);





    }


    class FieldFactory
    {

        private List<Battlefield> flyweights = new List<Battlefield>();


        public void Show(Battlefield args, int x, int y)
        {


            if (!flyweights.Contains(args))
            {

                flyweights.Add(args);

            }
            flyweights.Where(t => args == t).FirstOrDefault().Show(x, y);

        }

        public void ShowAll()
        {

            foreach (var item in flyweights)
            {
                item.Show(item.x, item.y);
            }
        }


    }


}


