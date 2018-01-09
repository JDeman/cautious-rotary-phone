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

            /******** dudes creation ********/
            IDude joe = new Dude();
            joe.Nationality = "Canadian";
            joe.Name = "Joe Black";
            IDude mike = new Dude();
            mike.Nationality = "French";
            mike.Name = "Mike Parson";
            mike.Weight = 105;
            IDude randy = new Dude();
            randy.Nationality = "German";
            randy.Name = "Randy Jackson";
            randy.Weight = 124;
            /********************************/

            for (var i = 0; i < 80; i++) Console.WriteLine("is is " + i);

            /********************************/

            IList<IDude> dudelist = new List<IDude>();

            dudelist.Add(mike);
            dudelist.Add(randy);

            randy.Greet();
            randy.WeightCheck();
            joe.Greet();
            joe.WeightCheck();
            mike.Greet();
            mike.WeightCheck();

            Console.WriteLine("boat is a " + boat.Brand + " " + boat.Model +
                              " and can hold " + boat.PersonCap + " dudes");

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

            if (boat.Brand != null) Console.WriteLine("boat brand is not null");

            foreach (var n in dudelist)
                if (n.Job == Jobs.Unemployed)
                    Console.WriteLine(n.Name + " is an " + n.Job + " sucker.");
                else
                    Console.WriteLine(n.Name + " is a " + n.Job + ".");

            Console.WriteLine("End.");
        }
    }
}