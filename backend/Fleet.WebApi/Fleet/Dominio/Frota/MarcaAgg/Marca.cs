using System.Collections.Generic;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.MarcaAgg
{

    public class Marca : EntityBase
    {
        public string Nome { get; set; }

        public virtual ICollection<Modelo> Modelos { get; protected set; }

        public static Marca Criar(string nome)
        {
            return new Marca() { Nome = nome }.GenerateIdentityAndReturn();
        }
    }
}
