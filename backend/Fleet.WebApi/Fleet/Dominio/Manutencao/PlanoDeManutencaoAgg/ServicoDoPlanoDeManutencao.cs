using System;
using Kereta.Dominio.Manutencao.ServicoAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.PlanoDeManutencaoAgg
{
    public class ServicoDoPlanoDeManutencao : EntityBase, IServico
    {
        protected ServicoDoPlanoDeManutencao() { }//EF

        public ServicoDoPlanoDeManutencao(Servico servico, PlanoDeManutencao plano)
        {
            ThrowIsNullOrTransient(servico, plano);

            Servico = servico;
            IdServico = servico.Id;

            //Copiando os dados do servico(congela as informações no servido do plano)
            TipoDeFrequencia = servico.TipoDeFrequencia;
            Instrucoes = servico.Instrucoes;
            QuantidadeAntecipacao = servico.QuantidadeAntecipacao;

            IdPlanoDeManutencao = plano.Id;
            PlanoDeManutencao = plano;
        }

        public Guid IdServico { get; protected set; }
        public virtual Servico Servico { get; protected set; }

        public Guid IdPlanoDeManutencao { get; protected set; }
        public virtual PlanoDeManutencao PlanoDeManutencao { get; protected set; }

        public TipoDeFrequencia TipoDeFrequencia { get; set; }
        public int QuantidadeAntecipacao { get; set; }

        public string Instrucoes { get; set; }
    }
}