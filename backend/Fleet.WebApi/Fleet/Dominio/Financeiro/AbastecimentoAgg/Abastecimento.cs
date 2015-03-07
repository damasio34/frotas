using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Financeiro.AbastecimentoAgg
{
    public class Abastecimento : EntityBase
    {
        public Guid IdVeiculo { get; set; }

        public virtual Veiculo Veiculo { get; set; }

        public Guid IdViagem { get; set; }

        public virtual Viagem Viagem { get; set; }

        public DateTime Data { get; set; }
        public virtual CombustivelDoVeiculo CombustivelDoVeiculo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }


    }
}
