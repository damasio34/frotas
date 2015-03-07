using Kereta.Dominio.Manutencao.OrdemDeServicoAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Estoque.EntradaAgg
{

  
    public class Entrada : EntityBase
    {
        public virtual ReadOnlyCollection<ItemDeConsumoDaEntrada> ItemDeConsumo { get; protected set; }

        public Guid IdFornecedor { get; set; }
        public virtual Fornecedor Fornecedor{ get; set; }
        public string NumeroNotaFiscal { get; set; }

    }
}
