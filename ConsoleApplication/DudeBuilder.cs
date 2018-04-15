using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class DudeBuilder
    {
        public IList<IDude> getDudes()
        {
            var list = new List<IDude>();
            
            /******** dudes creation ********/
            IDude joe = new Dude();
            joe.Nationality = "Canadian";
            yellow();
            joe.Name = "Joe Black";
            joe.Job = Jobs.Lumberjack;
            joe.Gender = Genders.Man;
            IDude mike = new Dude();
            mike.Nationality = "French";
            mike.Name = "Mike Parson";
            mike.Weight = 105;
            mike.Gender = Genders.Man;
            IDude randy = new Dude();
            randy.Nationality = "German";
            randy.Name = "Randy Jackson";
            randy.Weight = 124;
            randy.Gender = Genders.Man;
            IDude jessie = new Dude();
            jessie.Nationality = "American";
            jessie.Name = "Jessie Pinkman";
            jessie.Weight = 74;
            jessie.Job = Jobs.Salesman;
            jessie.Gender = Genders.Man;
            IDude pete = new Dude();
            pete.Nationality = "American";
            pete.Name = "Skinny Pete";
            pete.Weight = 61;
            pete.Job = Jobs.Gangster;
            pete.Gender = Genders.Man;
            IDude walter = new Dude();
            walter.Nationality = "American";
            walter.Name = "Walter White";
            walter.Weight = 70;
            walter.Job = Jobs.Chemist;
            walter.Gender = Genders.Man;
            IDude hank = new Dude();
            hank.Nationality = "American";
            hank.Name = "Hank Schrader";
            hank.Weight = 103;
            hank.Job = Jobs.Policeman;
            hank.Gender = Genders.Trans;
            IDude skyler = new Dude();
            skyler.Nationality = "American";
            skyler.Name = "Skyler White";
            skyler.Weight = 62;
            skyler.Job = Jobs.Unemployed;
            skyler.Gender = Genders.Woman;
            
            /********************************/
            
            list.Add(joe);
            list.Add(mike);
            list.Add(randy);
            list.Add(jessie);
            list.Add(pete);
            list.Add(walter);
            list.Add(hank);
            list.Add(skyler);

            Console.WriteLine(Environment.StackTrace);
            
            return list;
        }

        private void yellow()
        {
            Console.WriteLine("yellow!!");
        }
    }
}