using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class ProductCatalogue : ISearchable
    {
        private Dictionary<String, List<Product>> categoryProductMap;
        private Dictionary<String, List<Seller>> productSellerMap;

        private List<Product> products;
        private List<Category> categories;




        public ProductCatalogue()
        {
            products = new List<Product>();
            categories = new List<Category>();
            categoryProductMap = new Dictionary<string, List<Product>>();
            productSellerMap = new Dictionary<string, List<Seller>>();
        }

        private void updateCategoryProductMap()
        {
            foreach(Category category in categories)
            {
                
            }
        }



        public List<Product> SearchCategoryProducts(string categoryName)
        {
            if (this.categoryProductMap.ContainsKey(categoryName)){
                return categoryProductMap[categoryName];
            }
            else
            {
                Console.WriteLine("Error unable to find product of given category!");
                return null;
            }
        }




        public List<Product> SearchProduct(string productName)
        {
            throw new NotImplementedException();
        }
    }



}
