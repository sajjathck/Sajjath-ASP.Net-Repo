using Week2Assesement.Models;

namespace Week2Assesement.Repository
{
    public interface IStudentRepository
    {
        public void AddStudent(Student student);
        List<Student> GetAllStudents();
        List<Student> GetStudentsByQualification(string qualification);
        List<Student> GetStudentsBySkill(string skill);
        Student GetStudentById(int id);
        void UpdateStudentSkill(int id,string Skill);
        void UpdateStudentQualification(int id,string Qualification);
        void DeleteStudent(int id);
    }
}
