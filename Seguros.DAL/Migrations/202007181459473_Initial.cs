namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
            AddColumn("dbo.Insurances", "ClientID", c => c.Int(nullable: false));
            CreateIndex("dbo.Insurances", "ClientID");
            AddForeignKey("dbo.Insurances", "ClientID", "dbo.Clients", "ClientID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Insurances", "ClientID", "dbo.Clients");
            DropIndex("dbo.Insurances", new[] { "ClientID" });
            DropColumn("dbo.Insurances", "ClientID");
            DropTable("dbo.Clients");
        }
    }
}
