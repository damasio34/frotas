using Vvs.Domain.Seedwork;

namespace Kereta.Dominio.Frota
{
    public class Localizacao : ValueObject<Localizacao>
    {
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}