namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectFormatCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "ClientTypeId", c => c.Int());
            AddColumn("dbo.CustomerDetails", "ClassificationId", c => c.Int());
            AddColumn("dbo.CustomerDetails", "BusinessName", c => c.String());
            AddColumn("dbo.CustomerDetails", "Salutation", c => c.String());
            AddColumn("dbo.CustomerDetails", "PrimaryContact", c => c.String());
            DropColumn("dbo.Customers", "ClientTypeId");
            DropColumn("dbo.Customers", "ClassificationId");
            DropColumn("dbo.Customers", "BusinessName");
            DropColumn("dbo.Customers", "Salutation");
            DropColumn("dbo.Customers", "PrimaryContact");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PrimaryContact", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Salutation", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "BusinessName", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "ClassificationId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "ClientTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.CustomerDetails", "PrimaryContact");
            DropColumn("dbo.CustomerDetails", "Salutation");
            DropColumn("dbo.CustomerDetails", "BusinessName");
            DropColumn("dbo.CustomerDetails", "ClassificationId");
            DropColumn("dbo.CustomerDetails", "ClientTypeId");
        }
    }
}
