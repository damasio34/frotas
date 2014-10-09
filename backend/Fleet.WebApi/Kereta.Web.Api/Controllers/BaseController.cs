
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Refectory;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Controllers
{
    public class BaseController<T> : ApiController
        where T:EntityBase
    {
        public IRepository<T> _modeloRepository;

        public BaseController(IRepository<T> modeloRepository)
        {
            
            _modeloRepository = modeloRepository;
        }

        [Route("")]
        [HttpGet]
        public PageableResponse Get(ODataQueryOptions<T> options)
        {
            return _modeloRepository.Listar().GetPageableResult(options);
        }


    }
}
