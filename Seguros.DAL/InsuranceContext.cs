namespace Seguros.DAL
{
    using Seguros.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InsuranceContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Seguro' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Seguros.DAL.Seguro' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Seguro'  en el archivo de configuración de la aplicación.
        public InsuranceContext()
            : base("name=Seguro")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<RiskType> RiskTypes { get; set; }

        public DbSet<Category> Categories { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}