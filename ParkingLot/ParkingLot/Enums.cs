using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{

    public enum VehicleType
    {
        Car,Truck,Electric,Van,Motorbike
    }

    public enum ParkingSpotType
    {
        Handicapped,Compact,Large,Motorbike,Electric
    }

    public enum AccountStatus
    {
        Active,Blocked,Banned,Compromised,Archived,Unknown
    }

    public enum ParkingTicketStatus
    {
        Active,Paid,Lost
    }
}
