using System.Data.Entity;
using EmployeeManagementApp.Domain.Entities;

namespace EmployeeManagementApp.Domain
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}