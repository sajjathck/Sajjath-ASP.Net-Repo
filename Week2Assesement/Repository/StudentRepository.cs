using Week2Assesement.Models;

namespace Week2Assesement.Repository
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> students=new List<Student>()
        {
            new Student()
            {
                studentId= 0,Name="Sajjad",qualification= "B.tech",skill= "C#"
            }
        };
        public void AddStudent(Student student)
        {
            try
            {

                students.Add(student);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {

                var stud=(from s in students
                         where s.studentId == id
                         select s).SingleOrDefault();
                students.Remove(stud);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAllStudents()
        {
            try
            {

                return students;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetStudentById(int id)
        {
            try
            {

                Student student = (students.SingleOrDefault(s => s.studentId == id));
                return student;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentsByQualification(string qualification)
        {
            try
            {

                var stud = students.Where(x => x.qualification == qualification).ToList();
                return stud;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentsBySkill(string skill)
        {
            try
            {

                var stud = students.Where(x => x.skill == skill).ToList();
                return stud;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateStudentQualification(int id, string Qualification)
        {
            try
            {

                var student = students.SingleOrDefault(s => s.studentId == id);
                student.qualification = Qualification;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateStudentSkill(int id, string Skill)
        {
            try
            {

                var student = students.SingleOrDefault(s => s.studentId == id);
                student.skill = Skill;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
