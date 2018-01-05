
using System;

namespace ConsoleApplication
{
    public class Boat : IVehicle
    {
        public int MaxSpeed { get; set; } = 80;
        public int Weight { get; set; } = 2000;
        public int PersonCap { get; set; } = 7;
        public string Brand { get; set; } = "Ramco";
        public string Model { get; set; } = "crusher";
        public string WheelSide { get; set; } = "center";
        public int CurrentPassengers { get; set; }
        public bool IsDead { get; set; }

        public void waketch()
        {
            Console.WriteLine("sadewiz");
            Console.WriteLine("wanamatcha");
        }

        public void TurnRight()
        {
            Console.WriteLine("Boat is turning right!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Boat is turning left!");
        }

        public void LoadPeople(int nbPeople)
        {
            if (CurrentPassengers + nbPeople > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for " + nbPeople +
                                  " more dudes, Ya'll have to swim!");
            }
            else
            {
                CurrentPassengers += nbPeople;
                Console.WriteLine(nbPeople + " dudes loaded in Boat");
            }
        }

        public void Explode()
        {
            IsDead = true;
            Console.WriteLine("boooom !! " + CurrentPassengers + " dudes dead and sinking in the depths !!");
        }

        public void Yolo()
        {
            Console.WriteLine("Yolo Boat implementation");
        }
    }
}