using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Frota;


namespace Kereta.Infraestrutura.Data.Documentacao
{
    public class GravidadeDbMapping : EntityTypeConfiguration<Gravidade>
    {
        public GravidadeDbMapping()
        {
            HasKey(a => a.Id);

            
        }
    }

}


