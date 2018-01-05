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
            IDude joe = new Dude();
            IDude Mike = new Dude();
            IDude Randy = new Dude();
            IList<IDude> dudelist = new List<IDude>();
            dudelist.Add(Mike);
            dudelist.Add(Randy);
            
            Console.WriteLine("Type of ride object is => " + ride.Brand);
            if (ride.Brand == null) Console.WriteLine("Car has no Brand wtf");
            ride.PersonCap = 3;
            Console.WriteLine("boat is a " + boat.Brand + " " + boat.Model + 
                              " and can hold " + boat.PersonCap + " dudes");
            Console.WriteLine("Hello Dudes, Ya'll want a ride ?");

            ride.LoadPeople(joe);
            ride.LoadPeople(dudelist);
            ride.TurnLeft();
            ride.TurnRight();
            ride.Explode();

            Console.WriteLine("**********************");
            
            boat.LoadPeople(joe);
            boat.LoadPeople(dudelist);
            boat.TurnLeft();
            boat.TurnRight();
            boat.Explode();
           

            Console.WriteLine("End.");
        }
    }
}