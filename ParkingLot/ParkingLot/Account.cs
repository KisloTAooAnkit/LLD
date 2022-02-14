using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public abstract class Account
    {
        private string userName;
        private string password;
        private AccountStatus status;
        private Person person;
    }
}
