using System.Data.Entity.Migrations;

namespace EmployeeManagementApp.Domain.Migrations
{
    public partial class AddGUIDforemployeeid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeGuid", c => c.Guid(false));
        }

        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeGuid");
        }
    }
}