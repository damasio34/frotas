using System;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.ModeloAgg;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class Implemento : Veiculo
    {
        internal Implemento(Modelo modelo, Categoria categoria, CentroDeCusto centroDeCusto)
            : base(modelo, categoria, centroDeCusto)
        {

        }

         [Obsolete("EntityFramework")]
        protected Implemento() : base() { }


    }
}