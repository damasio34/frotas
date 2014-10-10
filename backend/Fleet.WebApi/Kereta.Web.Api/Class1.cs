using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;
using Vvs.Domain.Seedwork.Aplicacao;

namespace Kereta.Web.Api
{
    public class Metadata
    {
        public long TotalCount { get; set; }
    }

    public static class Extensions
    {
        public static PageableResponse GetPageableResult<T>(this IQueryable<T> queryable, ODataQueryOptions<T> queryOptions) where T : class
        {

            var applyed = queryOptions.ApplyTo(queryable);
            long count;
            if (queryOptions.Filter != null)
            {
                var onlyFilter = queryOptions.Filter.ApplyTo(queryable, new ODataQuerySettings());
                count = ((IQueryable<T>)onlyFilter).Count();
            }
            else
            {
                count = queryable.Count();
            }
            var retorno = new PageableResponse(applyed, count);
            return retorno;
        }

        public static Response<T> ToResponse<T>(this T entidade) where T : class
        {
            return Response.Ok(entidade);
        }
    }
}
