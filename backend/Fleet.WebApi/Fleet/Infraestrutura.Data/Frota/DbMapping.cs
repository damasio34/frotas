using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;

namespace Kereta.Infraestrutura.Data.Frota
{
    public class MarcaDbMapping : EntityTypeConfiguration<Marca>
    {
        public MarcaDbMapping()
        {
            HasKey(a => a.Id);

            
        }
    }

    public class SistemaDbMapping : EntityTypeConfiguration<Sistema>
    {
        public SistemaDbMapping()
        {
            HasKey(a => a.Id);
            HasMany(a=>a.SubSistemas)
                .WithRequired(a=>a.Sistema)
                .HasForeignKey(a=>a.IdSistema);
        }
    }

    public class SubSistemaDbMapping : EntityTypeConfiguration<SubSistema>
    {
        public SubSistemaDbMapping()
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


    public class VeiculoDbMapping : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoDbMapping()
        {
            HasKey(a => a.Id);
        }
    }

    public class CategoriaDbMapping : EntityTypeConfiguration<Categoria>
    {
        public CategoriaDbMapping()
        {
            HasKey(a => a.Id);
            Property(a => a.Nome).IsRequired();
        }
    }

    public class DocumentacaoDbMapping : ComplexTypeConfiguration<Documentacao>
    {
        public DocumentacaoDbMapping()
        {
            //Property(a => a.Chassi).IsRequired();
            //Property(a => a.Placa).IsRequired(); 
            //Property(a => a.Renavam).IsRequired();
        }
    }
}


