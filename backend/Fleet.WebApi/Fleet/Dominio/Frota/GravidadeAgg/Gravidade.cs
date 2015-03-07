using Kereta.Dominio.Refectory;
using System;


namespace Kereta.Dominio.Frota
{
    public class Gravidade : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Gravidade() { }

        internal Gravidade(string nome, decimal valor, GravidadeQualificacao gravidade)
        {
            GenerateNewIdentity();
            Nome = nome;
            Valor = valor;
            GravidadeQualificacao = gravidade;

        }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        public int Pontos
        {
            get { return (int)GravidadeQualificacao; }
            protected set {/*Usado pelo EntityFrameworkj para canonical functions */}
        }

        public GravidadeQualificacao GravidadeQualificacao { get; protected set; }

    }
}