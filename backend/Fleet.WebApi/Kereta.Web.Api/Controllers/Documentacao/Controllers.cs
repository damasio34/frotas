
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Vvs.Domain.Seedwork.Repositorios;
using Kereta.Dominio.Frota;

namespace Kereta.Web.Api.Controllers.Fiscal
{

    [RoutePrefix("documentacao/gravidades")]
    public class GravidadeController : BaseController<Gravidade>
    {
        public GravidadeController(IRepository<Gravidade> sistemaRepository)
            : base(sistemaRepository)
        {

        }
    }

}
