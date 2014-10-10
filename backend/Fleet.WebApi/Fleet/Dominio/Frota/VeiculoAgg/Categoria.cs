using System;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.VeiculoAgg
{

    public class Categoria : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Categoria() { }

        internal Categoria(string nome)
        {
            GenerateNewIdentity();
            Nome = nome;
        }
        public string Nome { get; set; }

    }



}
