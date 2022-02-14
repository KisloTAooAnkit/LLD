using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class ProductCatalogue : ISearchable
    {
        private Dictionary<String, List<Product>> categoryProductMap;
        private Dictionary<String, List<Seller>> productSellerMap;
        private Dictionary<String, List<Product>> similarProducts;

        private List<Product> products;
        private List<Category> categories;

        


        public ProductCatalogue()
        {
            products = new List<Product>();
            categories = new List<Category>();
            categoryProductMap = new Dictionary<string, List<Product>>();
            productSellerMap = new Dictionary<string, List<Seller>>();
            similarProducts = new Dictionary<string, List<Product>>();
            similarProducts.Add("Dummy product", new List<Product>());

        }

        public void updateSimilarProductsMap(Product newProduct)
        {
            String productName = newProduct.getName.ToLower();
            
            HashSet<String> keySet = new HashSet<string>(similarProducts.Keys);

            bool isSimilar = false;

            foreach(var key in keySet)
            {
                if(key.ToLower().Contains(productName) || productName.Contains(key.ToLower()))
                {
                    isSimilar = true;
                    similarProducts[key].Add(newProduct);
                }
            }

            if (!isSimilar)
            {
                similarProducts[newProduct.getName.ToLower()] = new List<Product>() { newProduct} ;
            }

        }



        public void updateCategoryProductMap()
        {
            foreach(Category category in categories)
            {
                categoryProductMap[category.getName.ToLower()] = new List<Product>();
            }
        }

        public void updateCategoryProductMap(Product product)
        {
            if (categoryProductMap.ContainsKey(product.getName.ToLower()))
            {
                categoryProductMap[product.getName.ToLower()].Add(product);
            }
            else
            {
                categoryProductMap[product.getName.ToLower()] = new List<Product>() { product };
            }
        }


        public void updateProductSellerMap(Product product)
        {
            if (productSellerMap.ContainsKey(product.getName.ToLower()))
            {
                productSellerMap[product.getName.ToLower()].Add(product.Seller);
            }
            else
            {
                productSellerMap[product.getName.ToLower()] = new List<Seller>() { product.Seller };
            }
        }

        public void addCategory(Category newCategory)
        {
            categories.Add(newCategory);
            updateCategoryProductMap();
        }

        public Dictionary<String , List<Product>> getSimilarProducts()
        {
            return similarProducts;
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
            return similarProducts[productName.ToLower()];
        }


        public void UpdateProductQuantity(Product product, int newQuantity)
        {
            foreach(Product prod in products)
            {
                if(prod.getId == product.getId)
                {
                    prod.AvailableCount = newQuantity;
                }
            }
        }


        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }



}
