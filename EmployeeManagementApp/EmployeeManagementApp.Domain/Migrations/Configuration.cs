using EmployeeManagementApp.Domain.Entities;

namespace EmployeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagementApp.Domain.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeManagementApp.Domain.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(x => x.EmployeeId,
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Aleksander",
                    MiddleName = "Jordan",
                    LastName = "Brown",
                    DateOfBirth = DateTime.Parse("10-23-1987"),
                    AvailableHours = "m-f 7:30-4",
                    DateOfHire = DateTime.Parse("07-15-2016"),
                    Department = "Fluid Power",
                    JobTitle = "Warehouse",
                    Salary = decimal.Parse("17.75"),
                    SalaryType = "Hourly",

                });
        }
    }
}
