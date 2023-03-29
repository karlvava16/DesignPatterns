using System;


namespace Flyweight
{
    class LightSoldiers : Battlefield
    {

        public LightSoldiers()
        {
            pic = this.GetType().Name + ".png";
            speed = 20;
            power = 10;

            x = 0;
            y = 0;
        }

        public override void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"{this.GetType().Name} My cords {x} {y}");
        }
    }

    class TransportCars : Battlefield
    {


        public TransportCars()
        {
            pic = this.GetType().Name + ".png";
            speed = 70;
            power = 0;
            x = 0;
            y = 0;
        }

        public override void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"{this.GetType().Name} My cords {x} {y}");
        }
    }
    class HeavyGroundTransport : Battlefield
    {


        public HeavyGroundTransport()
        {
            pic = this.GetType().Name + ".png";
            speed = 15;
            power = 150;
            x = 0;
            y = 0;
        }

        public override void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"{this.GetType().Name} My cords {x} {y}");
        }
    }
    class LightGroundTransport : Battlefield
    {

        public LightGroundTransport()
        {
            pic = this.GetType().Name + ".png";
            speed = 50;
            power = 30;
            x = 0;
            y = 0;
        }

        public override void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"{this.GetType().Name} My cords {x} {y}");
        }
    }
    class AirTransport : Battlefield
    {

        public AirTransport()
        {
            pic = this.GetType().Name + ".png";
            speed = 300;
            power = 100;
            x = 0;
            y = 0;
        }

        public override void Show(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"{this.GetType().Name} My cords {x} {y}");
        }
    }

}

