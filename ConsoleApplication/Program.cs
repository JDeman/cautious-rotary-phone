using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main()
        {
            IVehicle ride = new Car();
            IVehicle boat = new Boat();
            var dudeBuilder = new DudeBuilder();
            var dudelist = dudeBuilder.getDudes();

            DisplayAllDudesInfo(dudelist);
            StartJoyRide(ride, dudelist);
            StartJoyRide(boat, dudelist);
//            Console.WriteLine(Environment.StackTrace);
            Console.ReadLine();
        }

        private static void DisplayAllDudesInfo(IList<IDude> dudelist)
        {
            foreach (var dude in dudelist)
            {
                dude.ShowDudeInfo();
            }
        }

        private static void StartJoyRide(IVehicle vehicle, IList<IDude> dudelist)
        {
            vehicle.LoadPeople(dudelist);
            vehicle.TurnLeft();
            vehicle.TurnRight();
            vehicle.Explode();
        }
    }
}