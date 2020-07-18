namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Seguros.DAL.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Seguros.DAL.InsuranceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Seguros.DAL.InsuranceContext";
        }

        protected override void Seed(Seguros.DAL.InsuranceContext context)
        {

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.



        }
    }
}