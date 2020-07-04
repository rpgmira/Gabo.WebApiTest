using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gabo.Infrastructure.Context;
using Gabo.Infrastructure.Interfaces;
using Gabo.Models.Structure;

namespace Gabo.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly GaboContext _gaboContext;

        public CompanyRepository(GaboContext gaboContext)
        {
            _gaboContext = gaboContext;
        }

        public void Delete(int id)
        {
            var company = _gaboContext.Companies.Find(id);
            _gaboContext.Companies.Remove(company);
            _gaboContext.SaveChanges();
        }

        public Company Get(int id)
        {
            var company = _gaboContext.Companies.Find(id);
            return company;
        }

        public List<Company> GetAll()
        {
            var company = _gaboContext.Companies.ToList();
            return company;
        }

        public void Insert(Company company)
        {
            _gaboContext.Companies.Add(company);
            _gaboContext.SaveChanges();
        }

        public void Update(Company company)
        {
            _gaboContext.Companies.Update(company);
            _gaboContext.SaveChanges();
        }
    }
}
