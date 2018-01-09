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

            Console.WriteLine("boat is a " + boat.Brand + " " + boat.Model +" and can hold " + boat.PersonCap + " dudes");
            DisplayDudeInfo(dudelist);
            StartJoyRide(ride, dudelist);
            StartJoyRide(boat, dudelist);
            ShowDudesJobs(dudelist);
            Console.WriteLine("End.");
        }

        private static void DisplayDudeInfo(IList<IDude> dudelist)
        {
            foreach (var dude in dudelist)
            {
                dude.Greet();
                dude.WeightCheck();
            }
        }

        private static void StartJoyRide(IVehicle vehicle, IList<IDude> dudelist)
        {
            vehicle.LoadPeople(dudelist);
            vehicle.TurnLeft();
            vehicle.TurnRight();
            vehicle.Explode();
        }

        private static void ShowDudesJobs(IList<IDude> dudelist)
        {
            foreach (var n in dudelist)
                if (n.Job == Jobs.Unemployed)
                    Console.WriteLine(n.Name + " is an " + n.Job + " sucker.");
                else
                    Console.WriteLine(n.Name + " is a " + n.Job + ".");
        }
    }
}