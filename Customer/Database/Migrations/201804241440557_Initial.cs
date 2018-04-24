namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PrimaryAddress1 = c.String(),
                        PrimaryAddress2 = c.String(),
                        PrimaryCity = c.String(),
                        PrimaryState = c.String(),
                        PrimaryZipcode = c.Int(nullable: false),
                        SecondaryAddress1 = c.String(),
                        SecondaryAddress2 = c.String(),
                        SecondaryCity = c.String(),
                        SecondaryState = c.String(),
                        SecondaryZipcode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientTypeId = c.Int(nullable: false),
                        ClassificationId = c.Int(nullable: false),
                        BusinessName = c.String(nullable: false),
                        Salutation = c.String(nullable: false),
                        PrimaryContact = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDetails", "Id", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerDetails");
        }
    }
}
