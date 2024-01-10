using OnlineShoppingCartAPI.Models;

namespace OnlineShoppingCartAPI.Repository
{
    public interface IOrderRepo
    {
        //        •	The users are allowed to Place the Order by selecting the Products.
        void AddOrder(Order order);
//•	The users are allowed to View the list items ordered.
        List<Order> GetAll();
//•	The users are allowed to Delete the Products from the Order
        void DeleteProductfromOrder(int orderId, int productId);
    }
}
