/*3. Create an Order class that has order id, item name, order date and quantity. 
 * Create a collection of Order objects. 
 * Display the data day wise from most recently ordered to least recently ordered 
 * and by quantity from highest to lowest.*/
namespace Linq_Assignment
{
    class Order
    {
        public Order(int id, string? itemName, DateTime orderDate, int quantity)
        {
            Id = id;
            this.itemName = itemName;
            this.orderDate = orderDate;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string? itemName { get; set; }
        public DateTime orderDate { get; set; }
        public int Quantity { get; set; }
    }
    internal class OrderClass
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order ( 1,"Book      ",DateTime.Parse("2023-12-20"), 2200),
                new Order ( 2,"Pen       ",DateTime.Parse("2022-06-03"), 3000),
                new Order ( 3,"Pencil    ",DateTime.Parse("2022-08-15"), 2250),
                new Order ( 4,"Eraser    ",DateTime.Parse("2021-07-31"), 2000),
                new Order ( 5,"Sharpener ",DateTime.Parse("2023-02-16"), 1800)
            };
            //foreach(Order o in orders)
            //{
            //    Console.WriteLine(o.orderDate.ToShortDateString());
            //}
            var results=orders.OrderBy(o=>o.orderDate).ToList();
            Console.WriteLine("----------Order By Date-------------");
            foreach (var i in results)
            {
                Console.WriteLine($"ID : {i.Id} Name : {i.itemName} Date : {i.orderDate.ToShortDateString()} Quantity : {i.Quantity}");
            }

            var q =from i in orders
                   orderby i.Quantity descending
                   select i;

            Console.WriteLine("---------Order By Quantity-----------");
            foreach (var i in q)
            {
                Console.WriteLine($"ID : {i.Id} Name : {i.itemName} Date : {i.orderDate.ToShortDateString()} Quantity : {i.Quantity}");
            }

            var d = from i in orders
                    orderby i.orderDate descending
                    group i by i.orderDate.Month;
                    

            Console.WriteLine("-------------Order By Descending Date And Group By Month---------------");
            foreach (var k in d)
            {
                Console.WriteLine($"{k.Key} Group");
                foreach(var i in k)
                {
                    Console.WriteLine($"ID : {i.Id} Name : {i.itemName} Date : {i.orderDate.ToShortDateString()} Quantity : {i.Quantity}");

                }
            }

        }
    }
}
