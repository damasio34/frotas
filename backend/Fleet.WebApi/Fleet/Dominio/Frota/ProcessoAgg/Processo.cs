using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereta.Dominio.Frota.ProcessoAgg
{
  
    public class Processo : EntityBase
    {
        [Obsolete("Entity Framework")]
        protected Processo() { }

        internal Processo(string numero, SituacaoDoProcesso situacao, DateTime dataInicio)
        {
            GenerateNewIdentity();
            DataDeInicio = dataInicio;
            NumeroDoProcesso = numero;
            Situacao = situacao;
        }
        public DateTime DataDeInicio { get; set; }
        public DateTime? DataFinal { get; set; }
        public SituacaoDoProcesso Situacao { get; set; }

        public string NumeroDoProcesso { get; set; }

        public DateTime? DataDeVencimento { get; set; }
        public string Observacao { get; set; }
        public decimal Valor { get; set; }



    }
}
