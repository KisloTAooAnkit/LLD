using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class ParkingSpot
    {
        private string number;
        private bool free;
        private Vehicle vehicle;
        private ParkingSpotType type;

        public bool isFree()
        {
            return free;
        }

    }
}
