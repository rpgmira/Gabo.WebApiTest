using Gabo.Models.Structure;
using System.Collections.Generic;

namespace Gabo.Services.Interfaces
{
    public interface ICompanyService
    {
        void Insert(Company company);
        Company Get(int id);
        List<Company> GetAll();
    }
}
