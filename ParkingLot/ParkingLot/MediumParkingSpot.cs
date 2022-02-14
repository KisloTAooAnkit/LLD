namespace ParkingLot
{
    public class MediumParkingSpot : ParkingSpot
    {
        public MediumParkingSpot(string number, bool free, Vehicle vehicle, ParkingSpotType type) : base(number, free, vehicle, type)
        {
        }
    }
}
