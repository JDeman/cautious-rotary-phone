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
        public IList<IDude> CurrentPassengers { get; set; } = new List<IDude>();
        public bool IsWrecked { get; set; }

        public void TurnRight()
        {
            Console.WriteLine("Boat is turning right!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Boat is turning left!");
        }

        public void Explode()
        {
            IsWrecked = true;
            Console.WriteLine("boooom !! " + CurrentPassengers.Count + " dudes dead and sinking in the depths !!");
        }

        public void Yolo()
        {
            Console.WriteLine("Yolo Boat implementation");
        }

        public void LoadPeople(IList<IDude> dudesList)
        {
            var nbpeop = PersonCap - CurrentPassengers.Count;
            
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