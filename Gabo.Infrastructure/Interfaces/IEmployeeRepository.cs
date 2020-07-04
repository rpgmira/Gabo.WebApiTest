using System;
using System.Collections.Generic;
using System.Text;
using Gabo.Models.Structure;

namespace Gabo.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        Employee Get(int id);
        List<Employee> GetAll();
    }
}
