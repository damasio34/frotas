
using System;
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Refectory;
using Vvs.Domain.Seedwork.Aplicacao;
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


        [Route("{Id}")]
        [HttpGet]
        public Response<T> Get(Guid id)
        {
            return _modeloRepository.Selecionar(a => a.Id == id).ToResponse();
        }


    }
}
