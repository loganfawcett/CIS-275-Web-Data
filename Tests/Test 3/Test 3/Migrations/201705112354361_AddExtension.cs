namespace Test_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtension : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Extension", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Extension");
        }
    }
}
