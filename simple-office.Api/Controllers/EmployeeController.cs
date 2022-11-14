using Microsoft.AspNetCore.Mvc;
using simple_office.Domain.Interfaces.Repositories;
using simple_office.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace simple_office.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("SimpleOffice/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("", Name = "GetAllEmployees")]
        [Produces(typeof(IEnumerable<Employee>))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _employeeRepository.GetAll());
        }
    }
}
