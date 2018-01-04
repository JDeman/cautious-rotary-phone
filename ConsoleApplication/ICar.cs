namespace ConsoleApplication
{
    public interface ICar
    {
        int MaxSpeed { get; set; }
        int Weight { get; set; }
        int PersonCap { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        string WheelSide { get; set; }
        int CurrentPassengers { get; set; }
        bool IsDead { get; set; }
        
        void TurnRight();
        void TurnLeft();
        void LoadPeople(int nbPeople);
        void Explode();
    }
}