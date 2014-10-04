using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;

namespace Kereta.Infraestrutura.Data.Frota
{
    public class MarcaEntityTypeConfiguration : EntityTypeConfiguration<Marca>
    {
        public MarcaEntityTypeConfiguration()
        {
            HasKey(a => a.Id);
        }
    }

    public class ModeloEntityTypeConfiguration : EntityTypeConfiguration<Modelo>
    {
        public ModeloEntityTypeConfiguration()
        {
            HasKey(a => a.Id);
        }
    }
}
