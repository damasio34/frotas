using System.Collections.Generic;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.SistemaAgg
{
    public class Sistema : EntityBase
    {
        public string Nome { get; set; }
        public virtual ICollection<SubSistema> SubSistemas { get; set; }
    }
}