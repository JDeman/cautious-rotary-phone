using System.Collections.Generic;

namespace ConsoleApplication
{
    public interface IVehicle
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
        void LoadPeople(IDude dude);
        void LoadPeople(IEnumerable<IDude> dudesList);
        void Explode();
        void Yolo();
    }
}