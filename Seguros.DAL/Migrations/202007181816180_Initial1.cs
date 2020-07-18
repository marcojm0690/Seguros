namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "InsuranceId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Insurances", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Insurances", "IsActive");
            DropColumn("dbo.Clients", "IsActive");
            DropColumn("dbo.Clients", "InsuranceId");
        }
    }
}
