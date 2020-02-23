namespace CollegeManagementCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class View : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Subjects", newName: "Subject");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Subject", newName: "Subjects");
        }
    }
}
