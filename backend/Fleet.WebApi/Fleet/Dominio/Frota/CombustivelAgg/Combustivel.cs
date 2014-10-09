using System;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.CombustivelAgg
{

    public class Combustivel : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Combustivel() { }
        public string Nome { get; set; }

    }


}
