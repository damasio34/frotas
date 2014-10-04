using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Infraestrutura.Data.Frota;
using Kereta.Infraestrutura.Data.Migrations;
using Kereta.Migrations;
using Vvs.Domain.Seedwork.UnitOfWork;
using Vvs.Infraestrutura.Data.EF;

namespace Kereta.Infraestrutura.Data.Unit
{
    public interface IKeretaUnitOfWork : IUnitOfWork
    {
        
    }
    public class KeretaUnitOfWork : UnitOfWork, IKeretaUnitOfWork
    {
        public KeretaUnitOfWork()
            : base(Effort.DbConnectionFactory.CreateTransient(), true)
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
            
            modelBuilder.Configurations.Add(new MarcaEntityTypeConfiguration());


        }
    }
}
