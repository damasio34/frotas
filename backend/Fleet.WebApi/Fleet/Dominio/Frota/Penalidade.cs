using System;
using Vvs.Domain.Seedwork;

namespace Kereta.Dominio.Frota
{
    public class Penalidade : ValueObject<Penalidade>
    {
        public TipoPenalidade TipoPenalidade { get; set; }
        public DateTime? DataDaImpressao { get; set; }
        public DateTime? DataDoVencimento { get; set; }
        public decimal? Valor { get; set; }

    }
}