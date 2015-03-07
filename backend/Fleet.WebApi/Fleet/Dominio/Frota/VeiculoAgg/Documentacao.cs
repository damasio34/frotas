using System;
using Vvs.Domain.Seedwork;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class DocumentoDoCarro : ValueObject<DocumentoDoCarro>
    {
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public DateTime? DataDaCompra { get; set; }
        public decimal ValorDaCompra { get; set; }
        public DateTime? DataDeFabricacao { get; set; }
        public int AnoDoModelo { get; set; }

    }
}