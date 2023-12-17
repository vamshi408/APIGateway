using EmployeeService.Models;

namespace EmployeeService.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        List<Employee> AddEmployee(Employee employee);
        List<Employee> RemoveEmployee(int id);

    }
}
