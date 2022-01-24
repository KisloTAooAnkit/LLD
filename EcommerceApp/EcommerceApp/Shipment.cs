using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Shipment
    {
        private static int numberCounter = 0;
        private int shipmentNumber;
        private DateTime date;
        private DateTime estimatedArrival;
        private Order orderDetails;


        public Shipment(Order orderDetails)
        {
            shipmentNumber = ++numberCounter;
            date = DateTime.Now;
            estimatedArrival = date.AddDays(3);
            this.orderDetails = orderDetails;
            orderDetails.setOrderStatus(OrderStatus.Shipped);
        }
    }


    
}
