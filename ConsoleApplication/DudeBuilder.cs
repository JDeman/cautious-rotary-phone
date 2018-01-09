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
            joe.Name = "Joe Black";
            joe.Job = Jobs.Lumberjack;
            IDude mike = new Dude();
            mike.Nationality = "French";
            mike.Name = "Mike Parson";
            mike.Weight = 105;
            IDude randy = new Dude();
            randy.Nationality = "German";
            randy.Name = "Randy Jackson";
            randy.Weight = 124;
            IDude jessie = new Dude();
            jessie.Nationality = "American";
            jessie.Name = "Jessie Pinkman";
            jessie.Weight = 74;
            jessie.Job = Jobs.Salesman;
            IDude pete = new Dude();
            pete.Nationality = "American";
            pete.Name = "Skinny Pete";
            pete.Weight = 61;
            pete.Job = Jobs.Gangster;
            IDude walter = new Dude();
            walter.Nationality = "American";
            walter.Name = "Walter White";
            walter.Weight = 70;
            walter.Job = Jobs.Chemist;
            IDude hank = new Dude();
            hank.Nationality = "American";
            hank.Name = "Hank Schrader";
            hank.Weight = 103;
            hank.Job = Jobs.Policeman;
            /********************************/
            
            list.Add(joe);
            list.Add(mike);
            list.Add(randy);
            list.Add(jessie);
            list.Add(pete);
            list.Add(walter);
            list.Add(hank);

            return list;
        }
    }
}