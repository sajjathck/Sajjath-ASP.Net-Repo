namespace Linq_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 281,313,7,23,54,7,474,98,111,77,47,19,52,25};

            //var result = from n in nums
            //             where n * n*n > 100 && n *n* n < 1000
            //             select n * n*n;
            var result=nums.Where(x=>x>100 && x < 1000).ToArray();
            foreach (int n in result)
            {
                Console.WriteLine(n*n*n);
            }

        }
    }
}
