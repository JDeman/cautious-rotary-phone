using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVehicle ride = new Car();
            Console.WriteLine("Type of ride object is => " + ride.Brand);
            if (ride.Brand == null) Console.WriteLine("Car has no Brand wtf");
            ride.PersonCap = 3;
            Console.WriteLine("Hello Dudes, Ya'll want a ride ?");

            ride.LoadPeople(2);
            ride.LoadPeople(2);
            ride.TurnLeft();
            ride.TurnRight();
            ride.Explode();
            ride.Yolo();

            Console.WriteLine("End.");
        }
    }
}