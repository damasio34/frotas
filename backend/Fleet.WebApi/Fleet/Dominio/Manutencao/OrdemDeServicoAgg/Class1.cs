using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Manutencao.ServicoAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Manutencao.OrdemDeServicoAgg
{
    public class Fornecedor : EntityBase
    {
        public string Nome { get; set; }

    }

    public class OrdemDeServico:EntityBase
    {
        public Guid IdServico { get; set; }
        public virtual Servico Servico { get; set; }

        public Guid IdVeiculo { get; set; }
        public virtual Veiculo Veiculo { get; set; }

        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaTermino { get; set; }

        public Guid IdFornecedor { get; set; }

        public virtual Fornecedor Fornecedor{ get; set; }
        public Guid IdColaboradorResponsavel { get; set; }

        public virtual Colaborador ColaboradorResponsavel{ get; set; }

        

    }
}
