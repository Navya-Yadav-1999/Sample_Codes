using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> getEmployees();
    }
}
