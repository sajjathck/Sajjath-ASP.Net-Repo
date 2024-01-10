using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using Week2Assesement.Models;
using Week2Assesement.Repository;

namespace Week2Assesement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepo;

        public StudentController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent([FromBody]Student student)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _studentRepo.AddStudent(student);
                    return StatusCode(200, "Student Added");
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllCompany()
        {
            try
            {
                var stud = _studentRepo.GetAllStudents();
                return StatusCode(200, stud);


            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetStudentsByQualification/{qualification}")]
        public IActionResult GetStudentsByQualification(string qualification)
        {
            try
            {
                var stud = _studentRepo.GetStudentsByQualification(qualification);
                return StatusCode(200, stud);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetStudentsBySkill/{skill}")]
        public IActionResult GetStudentsBySkill(string skill)
        {
            try
            {
                var stud = _studentRepo.GetStudentsBySkill(skill);
                return StatusCode(200, stud);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var stud = _studentRepo.GetStudentById(id);
                return StatusCode(200, stud);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut]
        [Route("UpdateStudent/{id},{criteria},{s}")]
        public IActionResult UpdateStudent(int id,string criteria,string s)
        {
            try
            {

                if (criteria.ToLower() == "skill")
                {
                    _studentRepo.UpdateStudentSkill(id, s);
                    return StatusCode(200,"Updated Skill");
                }
                else if (criteria.ToLower() == "qualification")
                {
                    _studentRepo.UpdateStudentQualification(id, s);
                    return StatusCode(200,"Updated Qualification");
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {

                _studentRepo.DeleteStudent(id);
                return StatusCode(200);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
