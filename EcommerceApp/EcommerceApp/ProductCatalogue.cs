using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class ProductCatalogue : ISearchable
    {
        private Dictionary<String, List<Product>> categoryProductMap;

        private List<Product> products;
        private List<Category> categories;

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
    }



}
