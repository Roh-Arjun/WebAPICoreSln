using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Repository;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeRepos _repos;

        public ValuesController(IEmployeeRepos repos)
        {
            _repos = repos;
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            IEnumerable<Employee> employees= _repos.GetAll();
            if (employees.Count() > 0)
            {
                return Ok(employees);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            Employee emp= _repos.GetEmployee(id);
            if (emp != null)
            {
                return Ok(emp);
            }
            return NotFound();
        }
    }
}
