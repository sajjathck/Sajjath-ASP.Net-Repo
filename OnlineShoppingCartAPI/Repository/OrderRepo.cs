using OnlineShoppingCartAPI.Models;

namespace OnlineShoppingCartAPI.Repository
{
    public class OrderRepo : IOrderRepo
    {
        List<Order> orders=new List<Order>();
        public void PlaceOrder(Order order)
        {
            orders.Add(order);
        }

        public void DeleteProductfromOrder(int orderId, int productId)
        {
            var order = orders.FirstOrDefault(x => x.OrderId == orderId);
            if (order != null)
            {
                 orders.Remove(order);
            }
        }

        public List<Order> ViewOrder()
        {
            return orders;
        }
    }
}
