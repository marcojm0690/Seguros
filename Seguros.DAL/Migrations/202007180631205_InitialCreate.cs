namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 15),
                        Description = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RiskTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.RiskTypes", t => t.RiskTypeID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.RiskTypeID);
            
            CreateTable(
                "dbo.category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Percentage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.RiskTypes",
                c => new
                    {
                        RiskTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RiskTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Insurances", "RiskTypeID", "dbo.RiskTypes");
            DropForeignKey("dbo.Insurances", "CategoryID", "dbo.category");
            DropIndex("dbo.Insurances", new[] { "RiskTypeID" });
            DropIndex("dbo.Insurances", new[] { "CategoryID" });
            DropTable("dbo.RiskTypes");
            DropTable("dbo.category");
            DropTable("dbo.Insurances");
        }
    }
}
