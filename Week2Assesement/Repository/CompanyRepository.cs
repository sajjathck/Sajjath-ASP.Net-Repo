using Week2Assesement.Models;
using System.Linq;

namespace Week2Assesement.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        List<Company> _companies=new List<Company>()
        {
            new Company()
            {
                companyId = 0,
                Name = "RM",
                city = "TVM",
                address = "Technopark,Karyavattom PO"
            }
        };
        public void AddCompany(Company company)
        {
            try
            {

                _companies.Add(company);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCompany(int id)
        {
            try
            {
                var com = (from company in _companies
                          where company.companyId == id
                          select company).SingleOrDefault();
                
                    _companies.Remove(com);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetCompanies()
        {
            try
            {

                return _companies;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetCompanyByCity(string city)
        {
            try
            {

                var comp = (from c in _companies
                            where c.city == city
                            select c).ToList();
                return comp;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
            {

                var company = (from c in _companies
                               where c.companyId == id
                               select c).FirstOrDefault();
                return company;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
