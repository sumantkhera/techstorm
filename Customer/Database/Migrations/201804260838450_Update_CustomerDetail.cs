namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_CustomerDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "Phone", c => c.String());
            AddColumn("dbo.CustomerDetails", "Email", c => c.String());
            AddColumn("dbo.CustomerDetails", "Eicode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerDetails", "Eicode");
            DropColumn("dbo.CustomerDetails", "Email");
            DropColumn("dbo.CustomerDetails", "Phone");
        }
    }
}
