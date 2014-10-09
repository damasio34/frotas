
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Controllers.Frota
{
    [RoutePrefix("frota/modelos")]
    public class ModelosController : BaseController<Modelo>
    {
        public ModelosController(IRepository<Modelo> modeloRepository) : base(modeloRepository) { }
    }

    [RoutePrefix("frota/marcas")]
    public class MarcasController : BaseController<Marca>
    {
        public MarcasController(IRepository<Marca> modeloRepository) : base(modeloRepository) { }
    }
}
