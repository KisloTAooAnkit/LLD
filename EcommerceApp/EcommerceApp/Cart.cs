using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Cart
    {
        private List<Item> items;
        public List<Item> getItems { get { return items; } }

        public Cart()
        {
            items = new List<Item>();
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public void removeItem(Item item)
        {
            items.Remove(item);
        }

        public void printItems()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void checkOut()
        {
            items.Clear();
        }


        public void updateQuantity(Item item, int newCount)
        {
            var index = items.IndexOf(item);
            items[index].updateCount(newCount);
        }


    }
}
