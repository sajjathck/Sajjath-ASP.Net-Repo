using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class5
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Hari"),
                new Student(2,"Shankar"),
                new Student(3,"Subhash"),
                new Student(4,"Gandhi"),
                new Student(5,"Bhagath")
            };
            Student? s=students.FirstOrDefault();
            s=students.Where(s=>s.Name.Length>4).First();
            s = students.Where(s => s.Name.Length > 3).FirstOrDefault();
            s = students.Where(s => s.Name.Length > 4).Last();
            s = students.Where(s => s.Name.Length > 4).LastOrDefault();

            s = students.Single(s => s.Id == 1);
            s = students.SingleOrDefault(s => s.Id == 1 && s.Name.Length == 4);
            Console.WriteLine(s.Name);

            List<Student> l1=students.Where(s=>s.Name.Length>6).ToList();

            Student[] l2 = students.Where(s => s.Name.Length > 6).ToArray();
            Console.WriteLine(l1.Count);
            foreach(var i in l2)
            {
                Console.WriteLine($"Student: {i.Name}");
           //Console.WriteLine(i.Name);
            }
            Student l3=students.ElementAt(2);
            Console.WriteLine(l3.Name.Append('c'));
        }
    }
}
