using System.Collections.Generic;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class Cavalo : Veiculo
    {
        public ICollection<ImplementoDoCavalo> Implementos { get; set; }
    }
}