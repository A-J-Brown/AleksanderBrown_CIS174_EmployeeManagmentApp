using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using EmployeeManagementApp.Api.Models;
using EmployeeManagementApp.Domain;

namespace EmployeeManagementApp.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeContext _employeeContext;

        public EmployeeController()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<ICollection<EmployeeModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeModel
            {
                EmployeeId = x.EmployeeId,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                DateOfHire = x.DateOfHire,
                DateOfBirth = x.DateOfBirth,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                JobTitle = x.JobTitle,
                Department = x.Department,
                AvailableHours = x.AvailableHours,

            }).ToListAsync();

            return employees;
        }
    }
}
