using System;

namespace ConsoleApplication
{
    public class Dude : IDude
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; } = Genders.Undeined;
        public int Weight { get; set; } = 80;
        public string Nationality { get; set; }
        public string NativeLanguage { get; set; }
        public Jobs Job { get; set; } = Jobs.Unemployed;


        public void Greet()
        {
            Console.WriteLine("Hello I'm " + Name + ", I'm " + Nationality + ", nice to meet you.");
        }

        public string WeightCheck()
        {
            string res;
            
            if (Weight < 70)
                res = Name + " get your ass to KFC right now!";
            else if (Weight > 120)
                res = Name + " is bigger than Mobby Dick.";
            else if (Weight >= 100)
                res = Name + " needs to drop some pounds.";
            else
                res = Name + " is in good shape.";

            return res;
        }

        public void ShowDudeInfo()
        {
            Console.WriteLine(Name + " is a " + Nationality + " " + Job + " " + Gender + " who weighs " + Weight + " kg.");
        }
    }
}