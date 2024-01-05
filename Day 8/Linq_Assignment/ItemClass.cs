using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Item
    {
        public Item(string itemName, int price)
        {
            this.itemName = itemName;
            Price = price;
        }

        public string itemName { get; set; }
        public int Price { get; set; }
    }
    class ItemOrder{
        public ItemOrder(int id, string itemName, DateTime orderDate, int totalPrice)
        {
            Id = id;
            this.itemName = itemName;
            this.orderDate = orderDate;
            TotalPrice = totalPrice;
        }

        public int Id { get; set; }
        public string itemName { get; set; }
        public DateTime orderDate { get; set; }
        public int TotalPrice { get; set; }

    }
    internal class ItemClass
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
            List<Item> items = new List<Item> {
                new Item("Book      ", 35),
                new Item("Pen       ", 10),
                new Item("Pencil    ", 9),
                new Item("Eraser    ", 2),
                new Item("Sharpener ", 3),
            };

            var re = from o in orders
                      join i in items
                      on o.itemName equals i.itemName
                      select new ItemOrder(o.Id, i.itemName, o.orderDate, o.Quantity * i.Price);
            var res = from s in re
                      orderby s.orderDate descending
                      group s by s.orderDate.Month;

            foreach (var item in res)
            {
                Console.WriteLine($"Group - {item.Key}");
                foreach(var i in item)
                {
                    Console.WriteLine($"ID : {i.Id} Name : {i.itemName} Date : {i.orderDate.ToShortDateString()} Total Price:{i.TotalPrice}");
                }
            }
            //By using Anonymous Object
            var resu = from o in orders
                     join i in items
                     on o.itemName equals i.itemName
                     select new { id = o.Id, iname = i.itemName, odate = o.orderDate, totalprice = o.Quantity * i.Price };
            var resul= from s in resu
                      orderby s.odate descending
                      group s by s.odate.Month;

            Console.WriteLine($"By Using Anonymous Object");
            foreach (var item in resul)
            {
                Console.WriteLine($"Group - {item.Key}");
                foreach (var i in item)
                {
                    Console.WriteLine($"ID : {i.id} Name : {i.iname} Date : {i.odate.ToShortDateString()} Total Price:{i.totalprice}");
                }
            }

            
        }
    }
}
