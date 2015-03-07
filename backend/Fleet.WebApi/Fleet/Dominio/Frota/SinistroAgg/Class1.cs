using Kereta.Dominio.Frota.MotoristaAgg;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Frota.SinistroAgg
{
    public class Sinistro : EntityBase
    {
        protected Sinistro()
        {

        }
        internal Sinistro(VeiculoAgg.Veiculo veiculo, Motorista motorista)
        {
            GenerateNewIdentity();
        }

        public Guid IdVeiculo { get; set; }
        public virtual VeiculoAgg.Veiculo Veiculo { get; set; }

        public Guid IdMotorista { get; set; }

        public virtual Motorista Motorista { get; set; }
        public Localizacao LocalDoSinistro { get; set; }

        public string NomeDaSeguradora { get; set; }
        public string BO { get; set; }

    }
}
