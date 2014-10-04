using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Kereta.Infraestrutura.Data.Migrations
{
    public static class ExtentionDb
    {

        public static DbContext Update<TEntity>(this DbContext dbContext, params TEntity[] entities)
            where TEntity : class
        {
            dbContext.Set<TEntity>().AddOrUpdate(entities.ToArray());
            return dbContext;
        }
    }
}