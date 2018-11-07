using System.Data.Entity.Migrations;

namespace EmployeeManagementApp.Domain.Migrations
{
    public partial class InitializeDatabaseWithEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Employees",
                    c => new
                    {
                        EmployeeId = c.Int(false, true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        DateOfHire = c.DateTime(),
                        DateOfBirth = c.DateTime(),
                        Salary = c.Decimal(false, 18, 2),
                        SalaryType = c.String(),
                        JobTitle = c.String(),
                        Department = c.String(),
                        AvailableHours = c.String()
                    })
                .PrimaryKey(t => t.EmployeeId);
        }

        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}