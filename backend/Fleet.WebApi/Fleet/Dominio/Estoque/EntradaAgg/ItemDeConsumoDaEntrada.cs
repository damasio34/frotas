using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Estoque.EntradaAgg
{
    public class ItemDeConsumoDaEntrada : EntityBase
    {
        public Guid IdItemDeConsumo { get; set; }
        public virtual ItemDeConsumo ItemDeConsumo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public decimal ValorTotal
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
            set { }
        }


    }
}
