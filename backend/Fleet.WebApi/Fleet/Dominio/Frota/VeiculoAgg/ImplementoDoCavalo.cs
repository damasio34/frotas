using System;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class ImplementoDoCavalo : EntityBase
    {
        public Implemento Implemento { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataRemocao { get; set; }

        public int HodometroInicial { get; set; }
        public int HodometroFinal{ get; set; }
        
    }
}