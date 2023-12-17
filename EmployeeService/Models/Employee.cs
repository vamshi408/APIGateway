namespace EmployeeService.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public required string EmployeeName { get; set; }
        public required string EmployeeEmail { get; set; }
        public required string EmployeePhone { get; set; }
    }
}
