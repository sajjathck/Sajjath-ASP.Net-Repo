namespace OnlineShoppingCartAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
    }
}
