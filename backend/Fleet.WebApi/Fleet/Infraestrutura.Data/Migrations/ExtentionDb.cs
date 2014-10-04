using System.Data.Entity;
using System.Data.Entity.Migrations;

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
}