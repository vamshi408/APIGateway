using EmployeeService.Interfaces;
using EmployeeService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository= employeeRepository;
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var data= _employeeRepository.GetAllEmployees();
            return Ok(data);
        }

        [HttpGet("GetEmployeeByID")]
        public IActionResult GetEmployeeByID(int id)
        {
            var data = _employeeRepository.GetEmployeeById(id);
            return Ok(data);
        }


        [HttpGet("RemoveEmployeeByID")]
        public IActionResult RemoveEmployeeByID(int id)
        {
            var data = _employeeRepository.RemoveEmployee(id);
            return Ok(data);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            var data = _employeeRepository.AddEmployee(employee);
            return Ok(data);
        }
    }
}
