using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingCartAPI.Models;
using OnlineShoppingCartAPI.Repository;
using System.Security.Cryptography;

namespace OnlineShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        [HttpPost]
        [Route("addOrder")]
        public IActionResult PlaceOrder(Order order)
        {
            if (order != null)
            {
                _orderRepo.PlaceOrder(order);
                return StatusCode(200, "Order Placed Succesfully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("ViewOrder")]
        public IActionResult GetOrder()
        {
            var order=_orderRepo.ViewOrder();
            return StatusCode(200, order);
        }
        [HttpDelete]
        [Route("DeleteProductfromOrder")]
        public IActionResult DeleteOrder(int oid,int pid)
        {
            _orderRepo.DeleteProductfromOrder(oid, pid);
            return StatusCode(200, "Deleted Succesfully");
        }
    }
}
