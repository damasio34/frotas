using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Financeiro.AbastecimentoAgg
{
    public class Viagem:EntityBase
    {
        public Guid IdVeiculo { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public DateTime? DataDeSaida { get; set; }
        public DateTime? DataDeChegada { get; set; }
        public decimal TempoPrevisto { get; set; }




    }
}
