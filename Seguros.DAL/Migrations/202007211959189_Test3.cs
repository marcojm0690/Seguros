namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Insurances", "ClientID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Insurances", "ClientID", c => c.Int(nullable: false));
        }
    }
}
