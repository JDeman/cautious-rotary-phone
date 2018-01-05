using System;

namespace ConsoleApplication
{
    public class Car : ICar
    {
        public int MaxSpeed { get; set; }
        public int Weight { get; set; } = 1200;
        public int PersonCap { get; set; } = 5;
        public string Brand { get; set; } = "Toyota";
        public string Model { get; set; } = "Tacoma";
        public string WheelSide { get; set; } = "right";
        public int CurrentPassengers { get; set; }
        public bool IsDead { get; set; }

        public void TurnRight()
        {
            Console.WriteLine("Car is turning right!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car is turning left!");
        }

        public void LoadPeople(int nbPeople)
        {
            if (CurrentPassengers + nbPeople > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for " + nbPeople +
                                  " more dudes, Ya'll have to walk!");
            }
            else
            {
                CurrentPassengers += nbPeople;
                Console.WriteLine(nbPeople + " dudes loaded in car");
            }
        }

        public void Explode()
        {
            IsDead = true;
            Console.WriteLine("boooom !! " + CurrentPassengers + " dudes dead in the explosion !!");
        }

        public void Yolo()
        {
            Console.WriteLine("yolo");
        }
    }
}