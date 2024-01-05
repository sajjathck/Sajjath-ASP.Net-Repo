using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class1
    {
        static void Main()
        {
            List<Flower> FlowerList = new List<Flower>();
            FlowerList.Add(new Flower("Lotus", 25));
            FlowerList.Add(new Flower("Lilly", 5));
            FlowerList.Add(new Flower("Dafodils", 6));
            FlowerList.Add(new Flower("Hibiscus", 5));

            var result = from k in FlowerList
                         where k.Petals == 5 && k.Name.StartsWith("L")
                        select k;
            foreach(var f in result)
            {
              //  Console.WriteLine($"name : { f.Name} No Of Petals:{f.Petals}");
            }

            List<Flower> fList = new List<Flower>();
            fList.Add(new Flower("Lotus", 25));
            fList.Add(new Flower("Lilly", 5));
            fList.Add(new Flower("Jasmine", 35));
            fList.Add(new Flower("yilly", 9));
            fList.Add(new Flower("lly", 6));
            fList.Add(new Flower("Dafodils", 6));
            fList.Add(new Flower("Hibiscus", 5));

            var lquery = from j in fList
                         orderby j.Petals
                         group j by j.Petals; 
                         
            foreach (var t in lquery)
            {
                Console.WriteLine($"{t.Key} Petals Group:- ");
                foreach (var kj in t)
                {
                    Console.WriteLine(kj.Name);  
                }
            }
        }

    }
}
