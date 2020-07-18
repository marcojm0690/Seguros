namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "InsuranceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "InsuranceId", c => c.Int(nullable: false));
        }
    }
}
