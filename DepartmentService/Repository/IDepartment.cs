using DepartmentService.Models;

namespace DepartmentService.Repository
{
    public interface IDepartment
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        List<Department> AddDepartment(Department department);
        List<Department> RemoveDepartment(int id);
    }
}
