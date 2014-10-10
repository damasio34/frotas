using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;

namespace Kereta.Infraestrutura.Data.Frota
{
    public class FuncaoDoColaboradorDbMapping : EntityTypeConfiguration<FuncaoDoColaborador>
    {
        public FuncaoDoColaboradorDbMapping()
        {
            HasKey(a => a.Id);
        }
    }

    public class ColaboradorDbMapping : EntityTypeConfiguration<Colaborador>
    {
        public ColaboradorDbMapping()
        {
            HasKey(a => a.Id);

            HasRequired(a => a.Funcao);


        }
    }

}


