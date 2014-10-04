using System;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.ServicoAgg
{
    public class Servico : EntityBase, IServico
    {
        protected Servico() { }//EF

        public Servico(SubSistema subSistema)
        {
            AlterarSubsistema(subSistema);
        }

        public TipoDeFrequencia TipoDeFrequencia { get; set; }
        public string Nome { get; set; }

        public string Instrucoes { get; set; }

        public Guid IdSubSistema { get; set; }
        public virtual SubSistema SubSistema { get; protected set; }

        public void AlterarSubsistema(SubSistema subSistema)
        {
            if (subSistema == null) throw new ArgumentNullException();

            IdSubSistema = subSistema.Id;
            SubSistema = subSistema;
        }

        public int QuantidadeAntecipacao { get; set; }

    }
}