namespace ConsoleApplication
{
    public interface IDude
    {
        string Name { get; set; }
        int Age { get; set; }
        Genders Gender { get; set; }
        int Weight { get; set; }
        string Nationality { get; set; }
        string NativeLanguage { get; set; }
        Jobs Job { get; set; }

        void WeightCheck();
        void Greet();
        void ShowDudeInfo();
    }
}