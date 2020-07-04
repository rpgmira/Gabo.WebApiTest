using Gabo.Models.Structure;
using Gabo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gabo.WebApi.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // GET: api/<CompaniesController>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _companyService.GetAll();
        }

        // GET api/<CompaniesController>/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return _companyService.Get(id);
        }

        // POST api/<CompaniesController>
        [HttpPost]
        public void Post([FromBody] Company value)
        {
            _companyService.Insert(value);
        }
    }
}
