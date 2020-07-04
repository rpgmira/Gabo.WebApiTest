using Gabo.Infrastructure.Interfaces;
using Gabo.Models.Structure;
using Gabo.Services.Interfaces;
using System.Collections.Generic;

namespace Gabo.Services.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Company Get(int id)
        {
            return _companyRepository.Get(id);
        }

        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public void Insert(Company company)
        {
            _companyRepository.Insert(company);
        }
    }
}
