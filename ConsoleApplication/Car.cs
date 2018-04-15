using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApplication
{
    public class Car : IVehicle
    {
        public IList<IDude> CurrentPassengers { get; set; } = new List<IDude>();
        public int MaxSpeed { get; set; }
        public int Weight { get; set; } = 1200;
        public int PersonCap { get; set; } = 5;
        public string Brand { get; set; } = "Toyota";
        public string Model { get; set; } = "Tacoma";
        public string WheelSide { get; set; } = "right";
        public bool IsWrecked { get; set; }

        public void TurnRight()
        {
            Console.WriteLine("Car is turning right!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car is turning left!");
        }

        public void Explode()
        {
            IsWrecked = true;
            Console.WriteLine("boooom !! " + CurrentPassengers.Count + " dudes dead in the explosion !!");
        }
 
        public void Yolo()
        {
            Console.WriteLine("yolo car implementation");
        }

        public void LoadPeople(IList<IDude> dudesList)
        {
            int nbpeop = PersonCap - CurrentPassengers.Count;
            
            if (dudesList.Count > nbpeop)
                Console.WriteLine("Only " + PersonCap + " dudes can get in this vehicle");

            for (var i = 0; i < nbpeop; i++)
            {
                CurrentPassengers.Add(dudesList[i]);
                Console.WriteLine(dudesList[i].Name + " gets in " + Model + ".");
            }
        }
    }
}