using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementApp.Domain;
using EmployeeManagementApp.Domain.Entities;
using EmployeeManagementApp.Shared.Orchestrators.Interfaces;
using EmployeeManagementApp.Shared.ViewModels;

namespace EmployeeManagementApp.Shared.Orchestrators
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                EmployeeGuid = employee.EmployeeGuid,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                //DateOfHire = employee.DateOfHire,
                //DateOfBirth = employee.DateOfBirth,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                JobTitle = employee.JobTitle,
                Department = employee.Department,
                AvailableHours = employee.AvailableHours
            });

            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                EmployeeGuid = x.EmployeeGuid,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                DateOfHire = x.DateOfHire,
                DateOfBirth = x.DateOfBirth,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                JobTitle = x.JobTitle,
                Department = x.Department,
                AvailableHours = x.AvailableHours
            }).ToListAsync();

            return employees;
        }
    }
}