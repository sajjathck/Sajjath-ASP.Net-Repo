using Week2Assesement.Models;

namespace Week2Assesement.Repository
{
    public interface ICompanyRepository
    {
        public void AddCompany(Company company);
        public List<Company> GetCompanies();
        public List<Company> GetCompanyByCity(string city);
        public Company GetCompanyById(int id);
        public void DeleteCompany(int id);

    }
}
