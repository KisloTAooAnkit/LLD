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
        private string shippingAddress;



        public Order()
        {
            numberCounter += 1;
            this.orderID = numberCounter;
            orderLogs = new List<OrderLog>();
            addOrderLog(new OrderLog(DateTime.Now, OrderStatus.Created));
            
        }

        public void setOrderStatus(OrderStatus newStatus)
        {
            this.orderStatus = newStatus;
            addOrderLog(new OrderLog(DateTime.Now, orderStatus));
        }

        public void addOrderLog(OrderLog log)
        {
            orderLogs.Add(log);
        }

        public Shipment moveToShipment()
        {
            return new Shipment(this);
        }

        public void setOrderDate(DateTime date)
        {
            orderDate = date;
        }

        public void setItems(List<Item> items)
        {
            this.items = items;
        }

        public void setAmount(double amount)
        {
            this.orderAmount = amount;
        }

        public void setShippingAddress(string address)
        {
            shippingAddress = address;
        }


    }
}
