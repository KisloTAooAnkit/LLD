using System;
namespace ParkingLot
{
    public class Ticket
    {
        private Vehicle vehicle;
        private DateTime issueTime;
        private Person person;
        public Ticket(Person person)
        {
            Vehicle = person.Vehicle;
            this.Person = person;
            IssueTime = DateTime.Now;
        }

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public DateTime IssueTime { get => issueTime; set => issueTime = value; }
        public Person Person { get => person; set => person = value; }
    }
}
