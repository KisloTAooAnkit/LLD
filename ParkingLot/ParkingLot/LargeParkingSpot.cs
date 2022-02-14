using System;
namespace ParkingLot
{
    public class LargeParkingSpot : ParkingSpot
    {
        public LargeParkingSpot(string number, bool free, Vehicle vehicle, ParkingSpotType type) : base(number, free, vehicle, type)
        {
        }
    }
}
