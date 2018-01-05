using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Car : IVehicle
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

        public void LoadPeople(IDude dude)
        {
            if (CurrentPassengers + 1 > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for 1 more dude, You have to walk!");
            }
            else
            {
                CurrentPassengers ++;
                Console.WriteLine("1 dude loaded in car");
            }
        }

        public void LoadPeople(IEnumerable<IDude> dudesList)
        {
            var enumerable = dudesList.ToList();
            if (CurrentPassengers + enumerable.Count() > PersonCap)
            {
                Console.WriteLine("Not enough space in the ride for " + enumerable.Count() +
                                                  " more dudes, Ya'll have to walk!");
            }
            else
            {
                CurrentPassengers += enumerable.Count();
                Console.WriteLine(enumerable.Count() + " dudes loaded in car");
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