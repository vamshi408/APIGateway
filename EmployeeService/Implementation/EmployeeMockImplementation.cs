using EmployeeService.Interfaces;
using EmployeeService.Models;

namespace EmployeeService.Implementation
{
    public class EmployeeMockImplementation : IEmployeeRepository
    {

        public static List<Employee> EmployeeEntity;
        public EmployeeMockImplementation() 
        {
            EmployeeEntity= new List<Employee>();
            EmployeeEntity.Add(
                new Employee() { EmployeeId=1001, EmployeeName="Vamshi", EmployeeEmail="vamshi@gmail.com", EmployeePhone="1234567890" });
            EmployeeEntity.Add(
                new Employee() { EmployeeId = 1002, EmployeeName = "Krishna", EmployeeEmail = "Krishna@gmail.com", EmployeePhone = "1234567890" });
            EmployeeEntity.Add(
                new Employee() { EmployeeId = 1003, EmployeeName = "Bandi", EmployeeEmail = "Bandi@gmail.com", EmployeePhone = "1234567890" });
        }
        public List<Employee> AddEmployee(Employee employee)
        {
            EmployeeEntity.Add(employee);
            return EmployeeEntity;
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeeEntity;
        }

        public Employee GetEmployeeById(int id)
        {
            var data = EmployeeEntity.Where(e => e.EmployeeId == id).FirstOrDefault();
            return data;
        }

        public List<Employee> RemoveEmployee(int id )
        {
            var data = EmployeeEntity.Where(e => e.EmployeeId == id).FirstOrDefault();
            return EmployeeEntity;
        }
    }
}
