namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassificationName = c.String(nullable: false),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifyOn = c.DateTime(),
                        ModifyBy = c.Int(),
                        Version = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        ClientTypeName = c.String(nullable: false),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifyOn = c.DateTime(),
                        ModifyBy = c.Int(),
                        Version = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ClientTypeId = c.Int(),
                        ClassificationId = c.Int(),
                        BusinessName = c.String(),
                        Salutation = c.String(),
                        PrimaryContact = c.String(),
                        PrimaryAddress1 = c.String(),
                        PrimaryAddress2 = c.String(),
                        PrimaryCity = c.String(),
                        PrimaryState = c.String(),
                        PrimaryZipcode = c.Int(nullable: false),
                        IsSecondaryAddressSame = c.Boolean(nullable: false),
                        SecondaryAddress1 = c.String(),
                        SecondaryAddress2 = c.String(),
                        SecondaryCity = c.String(),
                        SecondaryState = c.String(),
                        SecondaryZipcode = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Eicode = c.String(),
                        Eicode2 = c.String(),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifyOn = c.DateTime(),
                        ModifyBy = c.Int(),
                        Version = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifyOn = c.DateTime(),
                        ModifyBy = c.Int(),
                        Version = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Token = c.String(),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifyOn = c.DateTime(),
                        ModifyBy = c.Int(),
                        Version = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "CustomerId" });
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerDetails");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.Classifications");
        }
    }
}
