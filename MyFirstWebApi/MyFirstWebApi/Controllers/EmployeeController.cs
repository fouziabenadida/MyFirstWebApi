using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Controllers.Models.Requests;
using MyFirstWebApi.Controllers.Models.Responses;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<GetEmployeeResponse> Employees = [];
        
        private static int _employeeIdCounter = 1;

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(Employees);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] CreateEmployeeRequest request)
        {
            // Hatalı
            // var company = Companies.FirstOrDefault(c => c.Id == request.CompanyId);
            // if (company == null)
            // {
            //     return BadRequest("The provided CompanyId does not exist in the Companies list.");
            // }

            var newEmployee = new GetEmployeeResponse
            {
                Id = _employeeIdCounter++,
                Name = request.Name,
                Surname = request.Surname,
                Salary = request.Salary,
                Birthday = request.Birthday,
                CompanyId = request.CompanyId
            };

            Employees.Add(newEmployee);
            return Ok();
        }
    }
}

