using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Kereta.Infraestrutura.Data.Frota;
using Kereta.Infraestrutura.Data.Migrations;
using Vvs.Infraestrutura.Data.EF;

namespace Kereta.Infraestrutura.Data
{
    
    public class KeretaUnitOfWork : UnitOfWork
    {
        public KeretaUnitOfWork()
            : base()
        {

            Database.SetInitializer(new CreateDatabaseIfNotExistsInitializer());
            
        }

        public KeretaUnitOfWork(DbConnection connection)
            : base(connection, true)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KeretaUnitOfWork, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new MarcaDbMapping());
            modelBuilder.Configurations.Add(new ModeloDbMapping());

        }
    }
}
