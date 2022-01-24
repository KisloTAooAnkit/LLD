using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Seller : User
    {
        private List<Product> products;


        public Seller(string name , string password)
        {
            base.setUser(name,password);
            products = new List<Product>();
        }

        public void RegisterNewProduct(ProductCatalogue productCatalogue,Product product)
        {
            product.Seller = this;
            productCatalogue.addProduct(product);
            products.Add(product);
        }

        public void updateProductQuantity(ProductCatalogue productCatalogue,Product product,int newQuantity)
        {
            productCatalogue.updateProduct(product, product, newQuantity);
        }

        public void removeProduct(ProductCatalogue productCatalogue,Product product)
        {
            productCatalogue.removeProduct(product);
            products.Remove(product);
        }
    }
}
