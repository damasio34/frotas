using System;
using System.Collections.Generic;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.MarcaAgg
{

    public class Marca : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Marca() { }

        public string Nome { get; set; }

        public virtual ReadOnlyCollection<Modelo> Modelos { get; protected set; }
        private ICollection<Modelo> _modelos { get { return Modelos; } }

        public void AdicionarModelo(Modelo modelo)
        {
            ThrowIsNullOrTransient(modelo);
            _modelos.Add(modelo);
        }

        public static Marca Criar(string nome)
        {
            return new Marca() { Nome = nome }.GenerateIdentityAndReturn();
        }
    }
}
