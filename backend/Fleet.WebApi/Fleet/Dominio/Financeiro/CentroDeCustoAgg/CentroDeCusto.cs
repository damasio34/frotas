using System;
using System.Security.Cryptography;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Financeiro.CentroDeCustoAgg
{

    public class CentroDeCusto : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected CentroDeCusto() { }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public CentroDeCusto(string nome, string descricao)
        {
            GenerateNewIdentity();
            Nome = nome;
            Descricao = descricao;
        }

    }



}
