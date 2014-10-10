using System;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Pessoal.Colaborador
{
    public class FuncaoDoColaborador : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected FuncaoDoColaborador() { }

        internal FuncaoDoColaborador(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHorariaPorMes = cargaHoraria;
            GenerateNewIdentity();
        }

        public string Nome { get; set; }

        public int CargaHorariaPorMes { get; set; }


    }
}