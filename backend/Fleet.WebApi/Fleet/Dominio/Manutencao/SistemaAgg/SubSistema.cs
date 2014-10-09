using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.SistemaAgg
{
    public class SubSistema : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected SubSistema() { }
        public string Nome { get; set; }
    }
}

