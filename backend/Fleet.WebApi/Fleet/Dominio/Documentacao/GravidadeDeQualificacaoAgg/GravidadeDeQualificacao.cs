using Kereta.Dominio.Refectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kereta.Dominio.Documentacao
{
    public class GravidadeDeQualificacao : EntityBase
    {
         [Obsolete("EntityFramework")]
        protected GravidadeDeQualificacao() { }

         internal GravidadeDeQualificacao(string nome, decimal valor, int pontosCarteira)
         {
             GenerateNewIdentity();
             Nome = nome;
             Valor = valor;
             PontosCarteira = pontosCarteira;

         }

         public string Nome { get; set; }
         public decimal Valor { get; set; }
         public int PontosCarteira { get; set; }

    }
}
