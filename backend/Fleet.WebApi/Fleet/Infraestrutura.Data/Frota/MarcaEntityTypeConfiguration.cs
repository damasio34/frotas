using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;

namespace Kereta.Infraestrutura.Data.Frota
{
    public class MarcaEntityTypeConfiguration : EntityTypeConfiguration<Marca>
    {
        public MarcaEntityTypeConfiguration()
        {

        }
    }
}
