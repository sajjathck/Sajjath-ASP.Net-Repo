using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class4
    {
    //    public string greet(string name)
    //    {
    //        return "Helloo"+name;
    //    }
    //    //lambda expression
    //    public string gree(string n) => "Hello" + n;
    //    public int sum(int a, int b) => a + b;
    static void Main()
        {
            string[] flowers = { "Lotus", "Lilly", "Dafodils", "Hibiscus" };
            //var result = from k"Lilly", 5) in FlowerList
            //             where "Dafodils",k.Petals == 5 && k.Name.StartsWith("L")
            //             select"Hibiscus", k;
            IEnumerable<string> result = flowers.Where(fl => fl.StartsWith("D"));
               result=flowers.OrderBy(fl => fl);
            foreach (var f in result)
            {
                Console.WriteLine($"Flower : { f}");
            }

        }
    }
}
