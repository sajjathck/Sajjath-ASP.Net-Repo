using OnlineShoppingCartAPI.Models;
using System;

namespace OnlineShoppingCartAPI.Repository
{
    public interface IProductRepo
    {
        //        •	Add the Product Details
        void AddProduct(Product product);
        //•	Modify the Product Details
        void UpdateProduct(Product product);
         //•	Delete the Product Details
        void DeleteProduct(string productName);
        //•	Users are allowed to search for the product details using the Product name OR the Product category.
        Product GetProductByName(string name);
        Product GetProductById(int id);
        //•	Users are allowed to search for the product details using Product category.
        List<Product> GetProductByCategory(string category);

    }
}
