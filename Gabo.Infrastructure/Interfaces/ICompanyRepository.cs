using Gabo.Models.Structure;
using System.Collections.Generic;

namespace Gabo.Infrastructure.Interfaces
{
    public interface ICompanyRepository
    {
        void Insert(Company company);
        void Update(Company company);
        void Delete(int id);
        Company Get(int id);
        List<Company> GetAll();
    }
}
