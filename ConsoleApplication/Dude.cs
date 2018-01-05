using System;

namespace ConsoleApplication
{
    public class Dude : IDude
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public string Nationality { get; set; }
        public string NativeLanguage { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hello I'm " +Name+ ", I'm " + Nationality + ", nice to meet you.");
        }
    }
}