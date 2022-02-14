using System;
using System.Collections.Generic;

namespace ParkingLot
{
    public class ParkingLot {

        private Address address;
        private List<ParkingFloor> parkingFloors;

        public ParkingLot(Address address)
        {
            this.address = address;
        }

        public void AddParkingFloor(ParkingFloor floor, int floorNum)
        {
            parkingFloors.Insert(floorNum - 1, floor);
        }

        public void AddParkingSpots(List<ParkingSpot> parkingSpots, int floorNum)
        {

        }

        public void DeleteParkingFloor(int floorNum)
        {

        }

        public void DeleteParkingSpot(int floorNum, int spotNum)
        {

        }

        public void showAddress()
        {

        }

        public Ticket bookTicket(Person person)
        {
            foreach(var floor in parkingFloors)
            {
                if (floor.checkOnThisFloor(person.Vehicle.Type))
                {
                    var ticket = new Ticket(person);
                }
            }

            

        }
    }
}
