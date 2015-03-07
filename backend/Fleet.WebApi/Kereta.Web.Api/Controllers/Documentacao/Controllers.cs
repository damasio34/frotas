
using System.Web.Http;
using System.Web.Http.OData.Query;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Vvs.Domain.Seedwork.Repositorios;
using Kereta.Dominio.Documentacao;

namespace Kereta.Web.Api.Controllers.Fiscal
{
   
    [RoutePrefix("documentacao/gravidadeDeQualificacao")]
    public class GravidadeDeQualificacaoController : BaseController<GravidadeDeQualificacao>
    {
        public GravidadeDeQualificacaoController(IRepository<GravidadeDeQualificacao> sistemaRepository) : base(sistemaRepository) { }
    }

}
