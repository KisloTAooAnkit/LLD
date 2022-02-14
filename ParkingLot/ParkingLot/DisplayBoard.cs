using System;
using System.Collections.Generic;
namespace ParkingLot
{
    public class DisplayBoard
    {
        private LargeParkingSpot availableLargeSpot;
        private MediumParkingSpot availableMediumParkingSpot;
        private LightParkingSpot availableLightParkingSpot;

        public LargeParkingSpot AvailableLargeSpot { get => availableLargeSpot; }
        public MediumParkingSpot AvailableMediumParkingSpot { get => availableMediumParkingSpot; }
        public LightParkingSpot AvailableLightParkingSpot { get => availableLightParkingSpot; }

        public DisplayBoard()
        {
        }


        public void updateBoard(LargeParkingSpot large,MediumParkingSpot medium,LightParkingSpot light)
        {
            this.availableLargeSpot = large;
            this.availableLightParkingSpot = light;
            this.availableMediumParkingSpot = medium;
        }


        public void printBoard()
        {
            Console.WriteLine("Hey this is the status of this floor :)");
        }
    }
}
