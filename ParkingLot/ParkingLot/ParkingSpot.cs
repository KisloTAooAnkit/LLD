using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class ParkingSpot
    {
        private int number;
        private bool free = true;
        private Vehicle vehicle;
        private ParkingSpotType type;

        public ParkingSpot(int number,ParkingSpotType type)
        {
            this.number = number;
            this.type = type;
        }

        public ParkingSpotType Type { get => type; }
        public Vehicle Vehicle { get => vehicle;}
        public bool Free { get => free;  }
        public int Number { get => number; }


        public void assignVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            this.free = false;
        }

        public void removeVehicle()
        {
            this.vehicle = null;
            free = true;
        }
    }
}
