namespace OnlineShoppingCartAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Category { get; set; }
        public float? Price { get; set; }
        public int stock { get; set; }
    }
}
