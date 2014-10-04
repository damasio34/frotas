using System.Collections.Generic;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Refectory;
using Kereta.Infraestrutura.Data.Migrations;
using Kereta.Infraestrutura.Data.Unit;

namespace Kereta.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    

    internal sealed class Configuration : DbMigrationsConfiguration<KeretaUnitOfWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(KeretaUnitOfWork context)
        {
            new SeedDatabase().Seed(context);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

    
    }
}
