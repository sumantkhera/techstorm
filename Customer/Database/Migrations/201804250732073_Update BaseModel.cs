namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBaseModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classifications", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Classifications", "ModifyOn", c => c.DateTime());
            AlterColumn("dbo.Classifications", "ModifyBy", c => c.Int());
            AlterColumn("dbo.Classifications", "Version", c => c.Int());
            AlterColumn("dbo.ClientTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.ClientTypes", "ModifyOn", c => c.DateTime());
            AlterColumn("dbo.ClientTypes", "ModifyBy", c => c.Int());
            AlterColumn("dbo.ClientTypes", "Version", c => c.Int());
            AlterColumn("dbo.CustomerDetails", "CreatedBy", c => c.Int());
            AlterColumn("dbo.CustomerDetails", "ModifyOn", c => c.DateTime());
            AlterColumn("dbo.CustomerDetails", "ModifyBy", c => c.Int());
            AlterColumn("dbo.CustomerDetails", "Version", c => c.Int());
            AlterColumn("dbo.Customers", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Customers", "ModifyOn", c => c.DateTime());
            AlterColumn("dbo.Customers", "ModifyBy", c => c.Int());
            AlterColumn("dbo.Customers", "Version", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Version", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "ModifyBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "ModifyOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerDetails", "Version", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerDetails", "ModifyBy", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerDetails", "ModifyOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CustomerDetails", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.ClientTypes", "Version", c => c.Int(nullable: false));
            AlterColumn("dbo.ClientTypes", "ModifyBy", c => c.Int(nullable: false));
            AlterColumn("dbo.ClientTypes", "ModifyOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClientTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifications", "Version", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifications", "ModifyBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifications", "ModifyOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classifications", "CreatedBy", c => c.Int(nullable: false));
        }
    }
}
