using System;
namespace ParkingLot
{
    public abstract class Vehicle
    {
        private string number;
        private VehicleType type;

        public VehicleType Type { get => type; set => type = value; }
    }
}
