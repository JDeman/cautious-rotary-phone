
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void LoadPeople(IDude dude)
        {
            if (CurrentPassengers + 1 > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for 1 more dude, You have to swim!");
            }
            else
            {
                CurrentPassengers ++;
                Console.WriteLine("1 dude loaded in boat");
            }
        }
        
        public void LoadPeople(IEnumerable<IDude> dudesList)
        {
            var enumerable = dudesList.ToList();
            if (CurrentPassengers + enumerable.Count() > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for " + enumerable.Count() +
                                  " more dudes, Ya'll have to swim!");
            }
            else
            {
                CurrentPassengers += enumerable.Count();
                Console.WriteLine(enumerable.Count() + " dudes loaded in boat");
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