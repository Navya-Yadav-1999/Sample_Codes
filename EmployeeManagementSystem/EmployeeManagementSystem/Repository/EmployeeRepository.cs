using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeDBContext _employeeDBContext;
        public EmployeeRepository(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext= employeeDBContext;
        }

        public List<Employee> getEmployees()
        {
            var employees=_employeeDBContext.Employee.ToList();
            return employees;
        }
    }
}
