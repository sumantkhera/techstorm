namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatekeyClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.CustomerDetails", "CustomerId");
            AddForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDetails", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "CustomerId" });
            DropColumn("dbo.CustomerDetails", "CustomerId");
        }
    }
}
