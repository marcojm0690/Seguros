namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Insurances", "CategoryID", "dbo.category");
            DropForeignKey("dbo.Insurances", "RiskTypeID", "dbo.RiskTypes");
            DropForeignKey("dbo.Insurances", "ClientID", "dbo.Clients");
            DropIndex("dbo.Insurances", new[] { "CategoryID" });
            DropIndex("dbo.Insurances", new[] { "ClientID" });
            DropIndex("dbo.Insurances", new[] { "RiskTypeID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Insurances", "RiskTypeID");
            CreateIndex("dbo.Insurances", "ClientID");
            CreateIndex("dbo.Insurances", "CategoryID");
            AddForeignKey("dbo.Insurances", "ClientID", "dbo.Clients", "ClientID", cascadeDelete: true);
            AddForeignKey("dbo.Insurances", "RiskTypeID", "dbo.RiskTypes", "RiskTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Insurances", "CategoryID", "dbo.category", "CategoryID", cascadeDelete: true);
        }
    }
}
