using System;

namespace EmployeeManagementApp.Api.Models
{
    public class EmployeeModel
    {
        //public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfHire { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public string SalaryType { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public int EmployeeId { get; set; }
        public string AvailableHours { get; set; }
    }
}