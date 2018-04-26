namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerDetails", "Id", "dbo.Customers");
            DropIndex("dbo.CustomerDetails", new[] { "Id" });
            DropPrimaryKey("dbo.CustomerDetails");
            AlterColumn("dbo.CustomerDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CustomerDetails", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CustomerDetails");
            AlterColumn("dbo.CustomerDetails", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CustomerDetails", "Id");
            CreateIndex("dbo.CustomerDetails", "Id");
            AddForeignKey("dbo.CustomerDetails", "Id", "dbo.Customers", "Id");
        }
    }
}
