using DepartmentService.Models;
using DepartmentService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;
        public DepartmentController(IDepartment department) { 
            _department = department;
        }

        [HttpGet("GetAllDepartment")]
        public IActionResult GetAllDepartment()
        {
            var data= _department.GetAllDepartments();
            return Ok(data);
        }

        [HttpGet("GetDepartmentById")]
        public IActionResult GetDepartmentById(int id)
        {
            var data = _department.GetDepartmentById(id);
            return Ok(data);
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment(Department department)
        {
            var data = _department.AddDepartment(department);
            return Ok(data);
        }

        [HttpGet("RemoveDepartment")]
        public IActionResult RemoveDepartment(int id)
        {
            var data = _department.RemoveDepartment(id);
            return Ok(data);
        }
    }
}
