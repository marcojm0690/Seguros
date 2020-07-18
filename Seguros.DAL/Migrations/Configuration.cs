namespace Seguros.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Seguros.DAL.Models;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Seguros.DAL.InsuranceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Seguros.DAL.InsuranceContext";
        }

        protected override void Seed(Seguros.DAL.InsuranceContext context)
        {
            context.Clients.AddOrUpdate(x => x.ClientID,
                new Client() { ClientID = 1, Name = "Marco Jimenez", Age = 30, IsActive = true }
                );

            context.Categories.AddOrUpdate(x => x.CategoryID,
                new Category() { CategoryID = 1, Name = "Fuego", Percentage = 25 }
                );

            context.RiskTypes.AddOrUpdate(x => x.RiskTypeId,
                     new RiskType() { RiskTypeId = 1, Name = "Alto" },
                     new RiskType() { RiskTypeId = 2, Name = "Medio" },
                     new RiskType() { RiskTypeId = 3, Name = "Bajo" }
            );


            context.Insurances.AddOrUpdate(x => x.ID,
                new Insurance { ID = 1, Name = "Insurance1", Description = "Insurance Description", Price = 1500, Amount = 6, StartDate = DateTime.Now, CategoryID = 1, ClientID = 1, RiskTypeID = 1 }
            );



            //    context.AddOrUpdate(new Insurance()
            //    {
            //        ID = 1,
            //        Description = "Test",
            //        Name = "Insurance1",
            //        Category = Category()
            //        {
            //    new Category() { CategoryID = 1, Name = "Fuego", Percentage=25},

            //}
            //    });


        }
    }
}