using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Customer : User
    {
        private Cart cart;
        private Order currentOrder;
        private List<Order> orderHistory;

        public List<Order> getOrderHistory { get { return orderHistory; } }
        public Order getCurrentOrder { get { return currentOrder; } }


        public Customer(string name,string password)
        {
            base.setUser(name, password);
            cart = new Cart();
            orderHistory = new List<Order>();
        }

        public void addToCart(Item item)
        {
            cart.addItem(item);
        }

        public void removeItemFromCart(Item item)
        {
            cart.removeItem(item);
        }

        public void printCartItems()
        {
            cart.printItems();
        }

        public void updateItemCount(Item item, int newQuantity)
        {
            cart.updateQuantity(item, newQuantity);
        }

        public void placeOrder()
        {
            currentOrder = new Order();
            //Should be in constructor
            currentOrder.setOrderStatus(OrderStatus.Unshipped);
            currentOrder.setOrderDate(new DateTime());
            var orderedItems = cart.getItemsList();
            var orderAmount = 0;
            foreach (var item in orderedItems)
            {
                orderAmount += item.getPrice();
            }
            currentOrder.setItems(orderedItems);
            currentOrder.setAmount(orderAmount);
            currentOrder.setShippingAddress(this.getAddress);
            this.cart.checkOut();
            this.orderHistory.Add(currentOrder);
        }

    }
}
