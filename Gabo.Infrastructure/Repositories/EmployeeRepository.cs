using Gabo.Infrastructure.Context;
using Gabo.Infrastructure.Interfaces;
using Gabo.Models.Structure;
using System.Collections.Generic;
using System.Linq;

namespace Gabo.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GaboContext _gaboContext;

        public EmployeeRepository(GaboContext gaboContext)
        {
            _gaboContext = gaboContext;
        }

        public void Delete(int id)
        {
            var employee = _gaboContext.Employees.Find(id);
            _gaboContext.Employees.Remove(employee);
            _gaboContext.SaveChanges();
        }

        public Employee Get(int id)
        {
            var employee = _gaboContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetAll()
        {
            var employees = _gaboContext.Employees.ToList();
            return employees;
        }

        public void Insert(Employee employee)
        {
            _gaboContext.Employees.Add(employee);
            _gaboContext.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _gaboContext.Employees.Update(employee);
            _gaboContext.SaveChanges();
        }
    }
}
