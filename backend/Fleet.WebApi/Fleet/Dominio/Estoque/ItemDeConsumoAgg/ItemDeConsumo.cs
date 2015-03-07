using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Estoque
{
   public class ItemDeConsumo:EntityBase
    {
        public string Nome { get; set; }
        public Guid IdSubSistema { get; set; }
        public virtual SubSistema SubSistema{ get; set; }

    }
}
