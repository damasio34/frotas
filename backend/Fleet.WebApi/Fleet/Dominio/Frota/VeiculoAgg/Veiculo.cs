using System;
using System.Collections.Generic;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.MotoristaAgg;
using EntityBase = Kereta.Dominio.Refectory.EntityBase;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public abstract class Veiculo : EntityBase
    {
        [Obsolete("EntityFramework")]
        protected Veiculo() { Documentacao = new DocumentoDoCarro(); }

        protected Veiculo(Modelo modelo, Categoria categoria, CentroDeCusto centroDeCusto)
        {
            AlterarModelo(modelo);
            AlterarCategoria(categoria);
            AlterarCentroDeCusto(centroDeCusto);
            Documentacao = new DocumentoDoCarro();
            GenerateNewIdentity();
        }
        public string Nome { get; set; }

        public Guid IdModelo { get; protected set; }
        public virtual Modelo Modelo { get; protected set; }
        public void AlterarModelo(Modelo modelo)
        {
            ThrowIsNullOrTransient(modelo);

            Modelo = modelo;
            IdModelo = modelo.Id;
        }

        public Guid IdCentroDeCusto { get; protected set; }
        public virtual CentroDeCusto CentroDeCusto { get; protected set; }

        public void AlterarCentroDeCusto(CentroDeCusto centroDeCusto)
        {
            ThrowIsNullOrTransient(centroDeCusto);
            CentroDeCusto = centroDeCusto;
            IdCentroDeCusto = centroDeCusto.Id;
        }

        public bool Ativo { get; set; }

        public string Placa { get; set; }

        public Guid IdCategoria { get; protected set; }
        public virtual Categoria Categoria { get; protected set; }
        public void AlterarCategoria(Categoria categoria)
        {
            ThrowIsNullOrTransient(categoria);

            Categoria = categoria;
            IdCategoria = categoria.Id;
        }

        public virtual ICollection<Motorista> Motoristas { get; protected set; }

        public virtual ICollection<CombustivelDoVeiculo> Combustiveis { get; protected set; }

        public decimal HodometroInicial { get; set; }

        public decimal HodometroDeVencimento { get; set; }

        public int Tara { get; set; }

        public int Lotacao { get; set; }

        public DocumentoDoCarro Documentacao { get; set; }

    }
}
