using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }
    internal class Class3
    {
        static void Main()
        {
            Student[] students =
            {
                new Student (1,"Hari" ),
                new Student (2,"faris" ),
                new Student (3,"Mubeena" ),
                new Student (4,"Amal" )

            };

            Enroll[] enrolls =
            {
                new Enroll(1,".net"),
                new Enroll(2,"python"),
                new Enroll(3,"python"),
                new Enroll(4,".net"),
                new Enroll(1,"python")

            };

            var result = from student in students
                         from enrollment in enrolls
                         where student.Id == enrollment.Id
                         // select new StudentEnroll (student.Id,student.Name,enrollment.CourseName );
                         select new { Id=student.Id,Name=student.Name, CourseName=enrollment.CourseName };
            foreach ( var i in result)
            {
                Console.WriteLine ($"id={i.Id} Name={i.Name} Course={i.CourseName}");
            }
        }
    }
}
