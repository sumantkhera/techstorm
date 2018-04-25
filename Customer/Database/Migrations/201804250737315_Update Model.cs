namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classifications", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.ClientTypes", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.CustomerDetails", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CustomerDetails", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClientTypes", "CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classifications", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
