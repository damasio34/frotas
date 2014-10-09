using System;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.ModeloAgg
{

    public class Modelo : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Modelo() { }
        public Guid IdMarca { get; protected set; }
        public virtual Marca Marca { get; protected set; }

        public string Nome { get; set; }

        public void AlterarMarca(Marca marca)
        {
            ThrowIsNullOrTransient(marca);

            Marca = marca;
            IdMarca = marca.Id;
        }

        public int QuantidadeDeEstepes { get; set; }
        public string Layout { get; set; }

        public Modelo(Marca marca, int quantidade, string nome)
        {
            AlterarMarca(marca);
            QuantidadeDeEstepes = quantidade;
            Nome= nome;
        }

    }

}
