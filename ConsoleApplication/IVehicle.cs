﻿using System.Collections.Generic;

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
        IList<IDude> CurrentPassengers { get; set; }
        bool IsWrecked { get; set; }

        void TurnRight();
        void TurnLeft();
        void LoadPeople(IList<IDude> dudesList);
        void Explode();
        void Yolo();
    }
}