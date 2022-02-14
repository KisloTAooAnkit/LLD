using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string state;
        private string zipcode;
        private string country;

        public Address(string streetAddress, string city, string state, string zipcode, string country)
        {
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
            this.Country = country;
        }

        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string Country { get => country; set => country = value; }
    }
}
