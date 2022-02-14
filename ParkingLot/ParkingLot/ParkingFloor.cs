using System;
using System.Collections.Generic;
namespace ParkingLot
{
    public class ParkingFloor
    {
        private int floorId = 0;
        private DisplayBoard displayBoard;
        private Dictionary<int, LightParkingSpot> lightSpots = new Dictionary<int, LightParkingSpot>();
        private Dictionary<int, MediumParkingSpot> mediumSpots = new Dictionary<int, MediumParkingSpot>();
        private Dictionary<int, LargeParkingSpot> largeSpots = new Dictionary<int, LargeParkingSpot>();
        private int lightSpotsCount;
        private int mediumSpotsCount;
        private int largeSpotsCount;

        public int FloorId { get => floorId;}

        public ParkingFloor(DisplayBoard displayBoard,int id)
        {
            this.displayBoard = displayBoard;
            floorId = id;
        }

        public bool checkOnThisFloor(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Car:
                    return mediumSpotsCount > 0;

                case VehicleType.Van:
                    return mediumSpotsCount > 0;

                case VehicleType.Electric:
                    return mediumSpotsCount > 0;

                case VehicleType.Truck:
                    return largeSpotsCount > 0;

                case VehicleType.Motorbike:
                    return lightSpotsCount > 0;

                default:
                    return false;
            }
        }

        public void registerVehicle(Vehicle vehicle)
        {

        }


      


        private void bookSpotLight(Vehicle vehicle)
        {
            foreach(var kvp in lightSpots)
            {
                if (kvp.Value.Free)
                {
                    var slot = kvp.Value;
                    slot.assignVehicle(vehicle);
                    break;
                }
            }
        }


        private void bookSpotMedium(Vehicle vehicle)
        {

        }

        private void bookSpotLarge(Vehicle vehicle)
        {

        }

    }
}
