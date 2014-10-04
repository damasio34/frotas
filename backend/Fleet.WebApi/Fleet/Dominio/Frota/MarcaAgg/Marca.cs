using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.MarcaAgg
{

    public class Marca : EntityBase
    {
        public string Nome { get; set; }

        public static Marca Criar(string nome)
        {
            return new Marca() { Nome = nome }.GenerateIdentityAndReturn();
        }
    }
}
