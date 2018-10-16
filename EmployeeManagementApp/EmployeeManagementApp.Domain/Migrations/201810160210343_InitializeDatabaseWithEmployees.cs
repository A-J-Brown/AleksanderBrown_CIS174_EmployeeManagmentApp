namespace EmployeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabaseWithEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        DateOfHire = c.DateTime(),
                        DateOfBirth = c.DateTime(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryType = c.String(),
                        JobTitle = c.String(),
                        Department = c.String(),
                        AvailableHours = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
