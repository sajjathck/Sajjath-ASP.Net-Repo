using OnlineShoppingCartAPI.Models;
using System.Xml.Linq;

namespace OnlineShoppingCartAPI.Repository
{
    public class ProductRepo : IProductRepo
    {
        List<Product> products=new List<Product>()
        {
  //productId": 0,
  //"productName": "string",
  //"category": "string",
  //"price": 0,
  //"stock": 0
        };
        public void AddProduct(Product product)
        {
            product.ProductId =products.Any() ?products.Max(x=>x.ProductId)+1 :100;
            products.Add(product);           
        }

        public void DeleteProduct(string productName)
        {
            var prod = (from p in products
                        where p.ProductName == productName
                        select p).SingleOrDefault();
            products.Remove(prod);
        }

        public List<Product> GetProductByCategory(string category)
        {
            var prod=(from p in products
                     where p.Category == category
                     select p).ToList();
            return prod;
        }

        public Product GetProductById(int id)
        {
            var prod = (from p in products
                        where p.ProductId == id
                        select p).SingleOrDefault();
            return prod;
        }

        public List<Product> GetProductByNameOrCategory(string keyword)
        {
            var prod = products.Where(p => p.ProductName.Contains(keyword) || p.Category.Contains(keyword)).ToList();
            return prod;
        }

        public void UpdateProduct(Product product)
        {
            var prod = (from p in products
                        where p.ProductId == product.ProductId
                        select p).SingleOrDefault();
                prod.ProductName = product.ProductName;
                prod.Price = product.Price;
                prod.Category = product.Category;
                prod.stock = product.stock;
            //prod = product;
        }
    }
}
