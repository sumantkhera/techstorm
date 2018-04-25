namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classifications", "ClassificationName", c => c.String(nullable: false));
            AlterColumn("dbo.ClientTypes", "ClientTypeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientTypes", "ClientTypeName", c => c.String());
            AlterColumn("dbo.Classifications", "ClassificationName", c => c.String());
        }
    }
}
