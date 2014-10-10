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

        public SubSistema(Sistema sistema, string nome)
        {
            ThrowIsNullOrTransient(sistema);
            Sistema = sistema;
            IdSistema = sistema.Id;
            Nome = nome;
        }

        public string Nome { get; set; }
        public virtual Sistema Sistema { get; protected set; }
        public Guid IdSistema { get; protected set; }
    }
}

