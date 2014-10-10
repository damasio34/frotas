using System;
using System.Collections.Generic;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Manutencao.SistemaAgg
{
    public class Sistema : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Sistema()
        {
            SubSistemas = new ReadOnlyCollection<SubSistema>();
        }

        internal Sistema(string nome)
        {
            GenerateNewIdentity();
            Nome = nome;
            SubSistemas = new ReadOnlyCollection<SubSistema>();

        }
        public string Nome { get; set; }
        public virtual ReadOnlyCollection<SubSistema> SubSistemas { get; protected set; }

        public void AdicionarSubSistemas(SubSistema subSistema)
        {
            ThrowIsNullOrTransient(subSistema);
            SubSistemas.Add(subSistema);
        }
    }
}