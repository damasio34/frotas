using System;
using Vvs.Domain.Seedwork;

namespace Kereta.Dominio.Frota
{
    public class Qualificacao : EntityBase
    {

        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public Guid IdGravidade { get; protected set; }
        public virtual Gravidade Gravidade { get; protected set; }

        public Guid IdInfrator { get; protected set; }
        public virtual Infrator Infrator { get; protected set; }

    }
}