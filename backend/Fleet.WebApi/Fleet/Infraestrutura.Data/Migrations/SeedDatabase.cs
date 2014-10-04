using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Infraestrutura.Data.Migrations
{
    public static class ExtentionDb
    {

        public static DbContext Update<TEntity>(this DbContext dbContext, params TEntity[] entities)
            where TEntity : class
        {
            dbContext.Set<TEntity>().AddOrUpdate(entities);
            return dbContext;
        }
    }

    public class SeedDatabase
    {
        public void Seed(DbContext context)
        {
            var marcas = CriarMarcas();

            context.Update(CriarMarcas().ToArray());
        }

        private IEnumerable<Marca> CriarMarcas()
        {
            yield return Marca.Criar("Agrale").ChangeIdentityAndReturn(Guid.Parse("19a08312-258b-4113-ad8d-712335760dd7"));
        }
    }


}
