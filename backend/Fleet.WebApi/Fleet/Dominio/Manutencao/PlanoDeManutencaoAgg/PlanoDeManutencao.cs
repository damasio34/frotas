using System;
using System.Collections.Generic;
using Kereta.Dominio.Manutencao.ServicoAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.PlanoDeManutencaoAgg
{
    public class PlanoDeManutencao : EntityBase
    {
        public string Nome { get; set; }
        public virtual ICollection<ServicoDoPlanoDeManutencao> Atividades { get; protected set; }

        public void AdicionarServico(Servico servico)
        {
            ThrowIsNullOrTransient(servico);
            var novoServico = ServicoFactory.CriarServicoParaUmPlano(this, servico);
            Atividades.Add(novoServico);

        }
    }
}