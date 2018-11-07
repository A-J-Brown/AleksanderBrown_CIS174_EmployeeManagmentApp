using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagementApp.Shared.ViewModels;

namespace EmployeeManagementApp.Shared.Orchestrators.Interfaces
{
    internal interface IEmployeeOrchestrator
    {
        Task<List<EmployeeViewModel>> GetAllEmployees();
        Task<int> CreateEmployee(EmployeeViewModel employee);
    }
}