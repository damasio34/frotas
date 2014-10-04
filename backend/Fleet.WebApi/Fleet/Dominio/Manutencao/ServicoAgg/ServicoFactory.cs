using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Manutencao.PlanoDeManutencaoAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.ServicoAgg
{
    public static class ServicoFactory
    {
        public static ServicoDoPlanoDeManutencao CriarServicoParaUmPlano(PlanoDeManutencao planoDeManutencao, Servico servico)
        {
            return new ServicoDoPlanoDeManutencao(servico, planoDeManutencao).GenerateIdentityAndReturn();
        }
    }
}
