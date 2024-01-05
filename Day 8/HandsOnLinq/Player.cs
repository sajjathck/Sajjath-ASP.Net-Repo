using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Player
    {
        public string? Name;
        public string? Country;

        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }

    class Player_Main
    {
        static void Main()
        {
            List<Player> list = new List<Player>();
            list.Add(new Player("Sachin","India"));
            list.Add(new Player("Ben Stokes", "UK"));

            List<Player> list1 = new List<Player>();
            list1.Add(new Player("Dhoni", "India"));
            list1.Add(new Player("Bobby", "US"));

            var r=from l1 in list
                  from l2 in list1
                  where l1.Country != l2.Country
                  select new {op=l1.Name,op1=l2.Name};
            foreach(var p in r)
            {
                Console.WriteLine($"{p.op}*{p.op1}");
            }
        }
    }
}
