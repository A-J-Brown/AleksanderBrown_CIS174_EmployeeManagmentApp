using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using EmployeeManagementApp.Models;
using EmployeeManagementApp.Shared.Orchestrators;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();

        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };

            return View(employeeDisplayModel);
        }

        public async Task<ActionResult> Create(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                return View();

            var updatedCount = await _employeeOrchestrator.CreateEmployee(new Shared.ViewModels.EmployeeViewModel
            {
                EmployeeGuid = Guid.NewGuid(),
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                DateOfHire = employee.DateOfHire,
                DateOfBirth = employee.DateOfBirth,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                JobTitle = employee.JobTitle,
                Department = employee.Department,
                AvailableHours = employee.AvailableHours
            });

            return View();
        }
    }
}