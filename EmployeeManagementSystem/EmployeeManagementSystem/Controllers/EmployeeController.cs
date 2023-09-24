using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var employees=_employeeRepository.getEmployees();
            return View(employees);
        }
		public IActionResult Create()
		{
			return View();
		}
	}
}
