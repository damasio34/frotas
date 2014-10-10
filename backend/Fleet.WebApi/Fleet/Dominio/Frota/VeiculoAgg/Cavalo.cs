using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.ModeloAgg;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class Cavalo : Veiculo
    {
        [Obsolete("EntityFramework")]
        protected Cavalo() : base() { }

        internal Cavalo(Modelo modelo, Categoria categoria, CentroDeCusto centroDeCusto)
            : base(modelo, categoria, centroDeCusto)
        {

        }
        public ReadOnlyCollection<ImplementoDoCavalo> Implementos { get; protected set; }
    }
}