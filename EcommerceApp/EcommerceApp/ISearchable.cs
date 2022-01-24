using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    interface ISearchable
    {
        public List<Product> SearchCategoryProducts(String categoryName);
        public List<Product> SearchProduct(String productName);
    }
}
