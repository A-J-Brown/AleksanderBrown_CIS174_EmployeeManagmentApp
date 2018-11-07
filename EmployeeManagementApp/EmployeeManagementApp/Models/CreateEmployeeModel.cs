﻿using System;

namespace EmployeeManagementApp.Models
{
    public class CreateEmployeeModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public string SalaryType { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string AvailableHours { get; set; }
    }
}