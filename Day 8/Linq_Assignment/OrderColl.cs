/*. Check if all the quantities in the Order collection is >0.
Get the name of the item that was ordered in largest quantity in a single order. (Hint: use LINQ methods to sort)
*/
namespace Linq_Assignment
{
    internal class OrderColl
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

            if (orders.All(s => s.Quantity > 0))
                {
                Console.WriteLine("All the quantities in the Order collection is >0 ");
            }
            var l = from i in orders
                    orderby i.Quantity 
                    select i;
            var la=orders.FirstOrDefault();

            Console.WriteLine("Largest: "+la.itemName);

            //Find if there are any orders placed before Jan of this year.
            DateTime jan2023= new DateTime(2023,01,01);
            bool j = orders.All(s => s.orderDate < jan2023);
            if (j)
            {
                Console.WriteLine("There are orders placed before Jan of this year");
            }
        }
    }
}
