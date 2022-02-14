using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class Person
    {
        private string name;
        private Address address;
        private string email;
        private string phone;
        private Vehicle vehicle;

        public Person(string name, Address address, string email, string phone, Vehicle vehicle)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.phone = phone ?? throw new ArgumentNullException(nameof(phone));
            this.vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
        }

        public string Name { get => name; set => name = value; }
        public Address Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }
}
