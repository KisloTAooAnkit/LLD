using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Order
    {
        private static int numberCounter = 0;
        private int orderNumber;
        private OrderStatus orderStatus;

        private List<Item> items;
        private List<OrderLog> orderLogs;
        private DateTime orderDate;
        private double orderAmount;
        private int orderID;
        


        public Order()
        {
            numberCounter += 1;
            this.orderID = numberCounter;
            orderLogs = new List<OrderLog>();
            addOrderLog(new OrderLog(new DateTime(),OrderStatus.Created));
            
        }


        public void addOrderLog(OrderLog log)
        {
            orderLogs.Add(log);
        }

        public Shipment moveToShipment()
        {
            return new Shipment();
        }




    }
}
