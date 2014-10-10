using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Frota.VeiculoAgg;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Controllers.Frota
{
    [RoutePrefix("frota/veiculos")]
    public class VeiculoController : BaseController<Veiculo>
    {
        public VeiculoController(IRepository<Veiculo> sistemaRepository) : base(sistemaRepository) { }

        [Route("implemento")]
        [HttpGet]
        public PageableResponse Get(ODataQueryOptions<Implemento> options)
        {
            return _modeloRepository.Listar().OfType<Implemento>().GetPageableResult(options);
        }

        [Route("cavalo")]
        [HttpGet]
        public PageableResponse Get(ODataQueryOptions<Cavalo> options)
        {
            return _modeloRepository.Listar().OfType<Cavalo>().GetPageableResult(options);
        }
    }
}