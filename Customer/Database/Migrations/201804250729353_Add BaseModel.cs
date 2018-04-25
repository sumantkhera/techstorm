namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBaseModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassificationName = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifyOn = c.DateTime(nullable: false),
                        ModifyBy = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        ClientTypeName = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifyOn = c.DateTime(nullable: false),
                        ModifyBy = c.Int(nullable: false),
                        Version = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerDetails", "IsSecondaryAddressSame", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerDetails", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.CustomerDetails", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerDetails", "ModifyOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.CustomerDetails", "ModifyBy", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerDetails", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerDetails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "ModifyOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "ModifyBy", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Version", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsDeleted");
            DropColumn("dbo.Customers", "Version");
            DropColumn("dbo.Customers", "ModifyBy");
            DropColumn("dbo.Customers", "ModifyOn");
            DropColumn("dbo.Customers", "CreatedBy");
            DropColumn("dbo.Customers", "CreatedOn");
            DropColumn("dbo.CustomerDetails", "IsDeleted");
            DropColumn("dbo.CustomerDetails", "Version");
            DropColumn("dbo.CustomerDetails", "ModifyBy");
            DropColumn("dbo.CustomerDetails", "ModifyOn");
            DropColumn("dbo.CustomerDetails", "CreatedBy");
            DropColumn("dbo.CustomerDetails", "CreatedOn");
            DropColumn("dbo.CustomerDetails", "IsSecondaryAddressSame");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.Classifications");
        }
    }
}
