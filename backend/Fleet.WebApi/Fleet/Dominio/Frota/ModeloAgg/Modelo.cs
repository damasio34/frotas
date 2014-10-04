using System;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.ModeloAgg
{

    public class Modelo : EntityBase
    {
        public Guid IdMarca { get; set; }
        public Marca Marca { get; set; }

        public int QuantidadeDeEstepes { get; set; }

        public string Layout { get; set; }

    }

}
