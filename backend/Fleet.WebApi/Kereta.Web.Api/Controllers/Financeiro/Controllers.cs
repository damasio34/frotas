
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Controllers.Fiscal
{
   
    [RoutePrefix("financeiro/centrosdecusto")]
    public class CentroDeCustoController : BaseController<CentroDeCusto>
    {
        public CentroDeCustoController(IRepository<CentroDeCusto> sistemaRepository) : base(sistemaRepository) { }
    }

}
