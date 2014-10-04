using System;
using Kereta.Dominio.Frota.CombustivelAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class CombustivelDoVeiculo : EntityBase
    {
        public Guid IdCombustivel { get; set; }
        public virtual Combustivel Combustivel { get; set; }

        /// <summary>
        /// Quantidade de Litros
        /// </summary>
        public int CapacidadeDoTanque { get; set; }

        /// <summary>
        /// Quantidade de Quilômetros por litro
        /// </summary>
        public int ConsumoPadrao { get; set; }


    }
}