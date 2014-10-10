using System;
using Kereta.Dominio.Frota.MotoristaAgg;
using Vvs.Domain.Seedwork;

namespace Kereta.Dominio.Frota
{
    public class Notificacao : ValueObject<Notificacao>
    {
        public string Codigo { get; set; }
        public DateTime? DataDaImpressao { get; set; }
        public DateTime? DataDaDefesa { get; set; }
        
        public Guid IdMotorista { get; protected set; }
        public virtual Motorista Motorista { get; protected set; }
    }
}