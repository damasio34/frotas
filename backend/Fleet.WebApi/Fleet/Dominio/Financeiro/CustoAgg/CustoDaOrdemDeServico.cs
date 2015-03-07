using Kereta.Dominio.Frota.ProcessoAgg;
using Kereta.Dominio.Manutencao.OrdemDeServicoAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Financeiro.CustoAgg
{
    public class CustoDaOrdemDeServico : Custo
    {
        public Guid IdOrdemDeServico { get; set; }
        public virtual OrdemDeServico OrdemDeServico { get; set; }
    }
}
