using System.Security.Cryptography.X509Certificates;

namespace HandsOnLinq
{
    internal class Class2
    {
        static void Main()
        {
            DateTime orderDate;
            orderDate = DateTime.Now;
            Console.WriteLine(orderDate);

            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

        }
    }
}
