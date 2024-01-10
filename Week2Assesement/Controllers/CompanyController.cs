using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2Assesement.Models;
using Week2Assesement.Repository;

namespace Week2Assesement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public readonly ICompanyRepository _companyRepo;

        public CompanyController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany([FromBody]Company company)
        {
            if(ModelState.IsValid)
            {
                _companyRepo.AddCompany(company);
                return StatusCode(200, "Company Added");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            var comp= _companyRepo.GetCompanies();
            return StatusCode(200,comp);
                
        }
        [HttpGet]
        [Route("GetCompanyByCity/{City}")]
        public IActionResult GetCompanyByCity(string City) 
        {
            if (ModelState.IsValid)
            {
                var comp = _companyRepo.GetCompanyByCity(City);
                return StatusCode(200, comp);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetCompanyById{Id}")]
        public IActionResult GetCompanyById(int Id)
        {
            if (ModelState.IsValid)
            {
                var comp = _companyRepo.GetCompanyById(Id);
                return StatusCode(200, comp);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("DeleteCompany/{Id}")]
        public IActionResult Delete(int Id)
        {
            _companyRepo.DeleteCompany(Id);
            return StatusCode(200,"Delete Succesfull");
        }
    }
}
