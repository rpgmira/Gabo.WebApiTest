using System;
using Gabo.Models.Structure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gabo.WebApi.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employee1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Gabriel",
                LastName = "Muñoz",
                Birthday = new DateTime(1978, 10, 14),
                Document = 71791115
            };

            var employee2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Juan",
                LastName = "Mira",
                Birthday = new DateTime(1987, 04, 22),
                Document = 1128268856
            };

            var employees = new List<Employee>
            {
                employee1,
                employee2
            };

            return employees;
        }
    }
}
