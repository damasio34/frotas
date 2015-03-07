using Kereta.Dominio.Frota.ProcessoAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Financeiro.CustoAgg
{
    public class CustoDoProcesso : Custo
    {
        public Guid IdProcesso { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
