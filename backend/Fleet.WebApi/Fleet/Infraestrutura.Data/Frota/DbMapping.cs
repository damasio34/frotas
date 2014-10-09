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
    public class MarcaDbMapping : EntityTypeConfiguration<Marca>
    {
        public MarcaDbMapping()
        {
            HasKey(a => a.Id);

            
        }
    }

    public class ModeloDbMapping : EntityTypeConfiguration<Modelo>
    {
        public ModeloDbMapping()
        {
            HasKey(a => a.Id);

            HasRequired(a => a.Marca)
                .WithMany(a => a.Modelos)
                .HasForeignKey(a=>a.IdMarca);
        }
    }
}
