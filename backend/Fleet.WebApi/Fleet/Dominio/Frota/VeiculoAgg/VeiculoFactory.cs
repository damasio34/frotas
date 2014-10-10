using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.ModeloAgg;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public static class VeiculoFactory
    {
        public static Cavalo CriarCavalo(Modelo modelo, Categoria categoria, CentroDeCusto centroDeCusto)
        {
            var cavalo = new Cavalo(modelo, categoria, centroDeCusto);

            return cavalo;
        }

        public static Implemento CriarImplemento(Modelo modelo, Categoria categoria, CentroDeCusto centroDeCusto)
        {
            var cavalo = new Implemento(modelo, categoria, centroDeCusto);

            return cavalo;
        }
    }
}
