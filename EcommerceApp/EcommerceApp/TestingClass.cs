using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    public interface ICustomer
    {
        string name { get; set; }
        string address { get; set; }
        string productName { get; set; }
        decimal productAmount { get; set; }

        decimal CalculateDiscount();
    }

    public interface ICustomerWithInterst : ICustomer
    {
        decimal CalculateInterest();
    }

    public class TestCustomer : ICustomer
    {
        public string name { get; set ; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public decimal CalculateDiscount()
        {
            return 0;
        }
    }
    public class RestCustomer : ICustomer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public decimal CalculateDiscount()
        {
            return 0;
        }
    }


    public class FestCustomer : ICustomerWithInterst
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }

        public decimal CalculateDiscount()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }

    public class Caller
    {
        ICustomer customer1,customer2;
        public Caller(ICustomer c1, ICustomer c2)
        {
            customer1 = c1;
            customer2 = c2;
        }

        static void main(string [] args)
        {
            RestCustomer rc = new RestCustomer();
            TestCustomer tc = new TestCustomer();
            Caller caller = new Caller(rc,tc);
        }
    }

    

}
