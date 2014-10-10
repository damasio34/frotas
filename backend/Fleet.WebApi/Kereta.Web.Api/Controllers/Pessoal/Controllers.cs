using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Kereta.Dominio.Pessoal.Colaborador;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Controllers.Pessoal
{

    [RoutePrefix("pessoal/funcoesdocolaborador")]
    public class FuncoesDoColaboradorController : BaseController<FuncaoDoColaborador>
    {
        public FuncoesDoColaboradorController(IRepository<FuncaoDoColaborador> sistemaRepository) : base(sistemaRepository) { }
    }

    [RoutePrefix("pessoal/colaboradores")]
    public class ColaboradoresController : BaseController<Colaborador>
    {
        public ColaboradoresController(IRepository<Colaborador> sistemaRepository) : base(sistemaRepository) { }
    }
}
