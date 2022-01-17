using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    abstract class Transformer
    {
        protected int wheels;
        protected int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
            
        }
        public abstract void Run();
    }

    class Jet : Transformer
    {
        public override void Run()
        {
            Wheels = 3;
            Speed = 800;
            Console.WriteLine($"Transformer is transformed in Jet, haw {wheels} wheels and fly from sped: {speed}");
        }
    }

    class Car : Transformer
    {
        public override void Run()
        {
            Wheels = 4;
            Speed = 220;
            Console.WriteLine($"Transformer is transform in Car, haw {wheels} wheels and sped is: {speed}");
        }
    }

    class Ship : Transformer
    {
        public override void Run()
        {
            Speed = 40;
            Console.WriteLine($"Transformer is transform in Ship, are swimm whit sped: {speed}");
        }
    }
    class Program
    {
        enum LandScape
        {
            Transformer,
            Air,
            Road,
            Water
        }
        static void Main(string[] args)
        {
            Transformer jet = new Jet();
            Transformer car = new Car();
            Transformer ship = new Ship();
            
            LandScape now = LandScape.Water;
            Transformation(now);

            void Transformation(LandScape land)
            {
                switch (land)
                {
                    case LandScape.Transformer:
                        Console.WriteLine("I,m a Transformer");
                        break;
                    case LandScape.Air:
                        jet.Run();
                        break;
                    case LandScape.Road:
                        car.Run();
                        break;
                    case LandScape.Water:
                        ship.Run();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}