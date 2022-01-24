using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Product
    {
        private static int idCounter = 0;
        private int id;
        private int availableCount;
        private string name;
        private string description;
        private double price;
        private double ratings;
        private Category category;
       
        private Seller seller;

        public int getId { get { return id; } }
        public string getName { get { return name; } }
        public string getDescription { get { return description; } }
        public double getPrice { get { return price; } }
        public double getRatings { get { return ratings; } }
        public Category getCategory { get { return category; } }
        public Seller Seller { get { return seller; } set { seller = Seller; } }

        public int AvailableCount { get { return availableCount; } set { availableCount = AvailableCount; } }


        public Product(string name,string description,double price,Category category,Seller seller,int AvailableCount)
        {
            idCounter += 1;
            this.id = Product.idCounter;
            this.name = name;
            this.description = description;
            this.price = price;
            this.category = category;
            this.seller = seller;
            this.availableCount = AvailableCount;
        }

    }
}
