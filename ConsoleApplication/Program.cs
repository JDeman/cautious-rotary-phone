using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVehicle ride = new Car();
            IVehicle boat = new Boat();
            Console.WriteLine("Type of ride object is => " + ride.Brand);
            if (ride.Brand == null) Console.WriteLine("Car has no Brand wtf");
            ride.PersonCap = 3;
            Console.WriteLine("boat is a " + boat.Brand + " " + boat.Model + 
                              " and can hold " + boat.PersonCap + " dudes");
            Console.WriteLine("Hello Dudes, Ya'll want a ride ?");

            ride.LoadPeople(2);
            ride.LoadPeople(2);
            ride.TurnLeft();
            ride.TurnRight();
            ride.Explode();

            Console.WriteLine("**********************");
            
            boat.LoadPeople(2);
            boat.LoadPeople(6);
            boat.TurnLeft();
            boat.TurnRight();
            boat.Explode();
           

            Console.WriteLine("End.");
        }
    }
}