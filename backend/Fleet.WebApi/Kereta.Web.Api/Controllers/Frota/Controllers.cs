using System.Web.Http;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Vvs.Domain.Seedwork.Repositorios;
using Kereta.Dominio.Frota.ProcessoAgg;

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

    [RoutePrefix("frota/sistemas")]
    public class SistemasController : BaseController<Sistema>
    {
        public SistemasController(IRepository<Sistema> sistemaRepository) : base(sistemaRepository) { }
    }


    [RoutePrefix("frota/subsistemas")]
    public class SubSistemasController : BaseController<SubSistema>
    {
        public SubSistemasController(IRepository<SubSistema> sistemaRepository) : base(sistemaRepository) { }
    }


    [RoutePrefix("frota/categorias")]
    public class CategoriasController : BaseController<Categoria>
    {
        public CategoriasController(IRepository<Categoria> sistemaRepository) : base(sistemaRepository) { }
    }



    [RoutePrefix("frota/processos")]
    public class ProcessosController : BaseController<Processo>
    {
        public ProcessosController(IRepository<Processo> sistemaRepository) : base(sistemaRepository) { }
    }

}
