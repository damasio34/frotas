using Kereta.Dominio.Frota.ProcessoAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Frota;
using Kereta.Dominio.Financeiro.CustoAgg;

namespace Kereta.Dominio.Financeiro
{
    public class CustoDaInfracao : Custo
    {
        public Guid IdInfracao { get; set; }
        public virtual Infracao Infracao { get; set; }
    }
}
