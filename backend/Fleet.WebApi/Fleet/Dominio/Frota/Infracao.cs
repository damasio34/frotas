using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.VeiculoAgg;
using Vvs.Domain.Seedwork;


namespace Kereta.Dominio.Frota
{
    public class Infracao : EntityBase
    {
        [Obsolete("EntiotyFramnework")]
        public Infracao() { }

        internal Infracao(Cavalo cavalo)
        {
            GenerateNewIdentity();

            Cavalo = cavalo;
            IdCavalo = cavalo.Id;

            LocalInfracao = new LocalInfracao();
        }

        public Guid IdCavalo { get; protected set; }
        public virtual Cavalo Cavalo { get; protected set; }

        public DateTime DataInfracao { get; set; }

        public SituacaoDaInfracao SituacaoDaInfracao { get; set; }

        public Guid IdQualificacao { get; protected set; }
        public virtual Qualificacao Qualificacao { get; protected set; }

        public LocalInfracao LocalInfracao { get; protected set; }
        public Penalidade Penalidade { get; protected set; }

    }
}
