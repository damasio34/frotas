using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Pessoal.Colaborador
{
    public class Colaborador:EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Colaborador() { }

        internal Colaborador(FuncaoDoColaborador funcao, string nome)
        {
            AlterarFuncao(funcao);
            Nome = nome;
        }

        public Guid IdFuncao { get; protected set; }
        public virtual FuncaoDoColaborador Funcao { get; protected set; }

        public void AlterarFuncao(FuncaoDoColaborador funcao)
        {
            ThrowIsNullOrTransient(funcao);

            IdFuncao = funcao.Id;
            Funcao = funcao;
        }

        public string Nome { get; set; }
        
        public string Matricula { get; set; }

        public string NumeroCNH { get; set; }

        public DateTime? DataDeVencimentoCNH { get; set; }
        
        public CategoriaCNH CategoriaCnh { get; set; }

        public OrgaoEmissor OrgaoEmissor { get; set; }


    }
}
