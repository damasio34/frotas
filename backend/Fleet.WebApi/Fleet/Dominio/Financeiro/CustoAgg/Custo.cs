using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Financeiro.CustoAgg
{
    public abstract class Custo : EntityBase
    {
        public Guid IdVeiculo { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDeVencimento { get; set; }
    }

}
