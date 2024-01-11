using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingCartAPI.Models;
using OnlineShoppingCartAPI.Repository;
using System.Xml.Linq;

namespace OnlineShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        
        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpPost]
        [Route("addProduct")]
        public IActionResult addProduct(Product product)
        {
            
            if (product != null) 
            {
                _productRepo.AddProduct(product);
                return StatusCode(200, "Product Added Succesfully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("updateProduct")]
        public IActionResult updateProduct(Product product)
        {
            if (product != null)
            {
                if(product.ProductId!=0)
                {
                    _productRepo.UpdateProduct(product);
                    return StatusCode(200, "Updated Succesfully");
                }
                return NotFound();
            }
            return BadRequest();
        }
        //[HttpGet]
        //[Route("GetProductById")]
        //public IActionResult getProductById(int id) 
        //{
        //    if(id!=0)
        //    {
        //        var product = _productRepo.GetProductById(id);
        //        return StatusCode(200, product);
        //    }
        //    return NotFound();
        //}
        [HttpGet]
        [Route("GetProductByNameOrCategory")]
        public IActionResult getProductByNameOrCategory(string keyword)
        {
            if (keyword != null)
            {
                var product=_productRepo.GetProductByNameOrCategory(keyword);
                return StatusCode(200,product);
            }
            return NotFound();
        }
        //[HttpGet]
        //[Route("GetProductByCategory")]
        //public IActionResult getProductByCategory(string category)
        //{
        //    if(!string.IsNullOrEmpty(category))
        //    {
        //        var product = _productRepo.GetProductByCategory(category);
        //        return StatusCode(200, product);
        //    }
        //    return NotFound() ;
        //}
        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult Delete(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if(getProductByNameOrCategory(name)!=null)
                {
                    _productRepo.DeleteProduct(name);
                    return StatusCode(200, "Deleted Succesfully");
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}
