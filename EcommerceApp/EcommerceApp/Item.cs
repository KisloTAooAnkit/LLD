using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Item
    {
        private Product product;
        private int quantity;
        private double price;

        public void updateCount(int newCount)
        {
            price = (price / quantity) * newCount;
            quantity = newCount;
        }

        public Item(Product product , int count)
        {
            this.product = product;
            this.price = product.getPrice;
            this.quantity = count;
        }

        public override string ToString()
        {
            return $"ProductId : {product.getId} \nQuantity : {quantity} \nprice : {price}";
        }
    }
}
