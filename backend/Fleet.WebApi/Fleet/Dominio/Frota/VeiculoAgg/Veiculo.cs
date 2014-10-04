using System;
using System.Collections.Generic;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.MotoristaAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio.Frota.VeiculoAgg
{
    public class Veiculo : EntityBase
    {
        public string Nome { get; set; }

        public Guid IdModelo { get; set; }
        public virtual Modelo Modelo { get; set; }

        public Guid IdCentroDeCusto{ get; set; }
        public CentroDeCusto CentroDeCusto { get; set; }

        public bool Ativo { get; set; }

        public string Placa { get; set; }

        public Guid IdCategoriaDoVeiculo { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Motorista> Motoristas { get; set; }

        public virtual ICollection<CombustivelDoVeiculo> Combustiveis { get; set; }

        public decimal HodometroInicial { get; set; }

        public decimal HodometroDeVencimento { get; set; }

        public int Tara{ get; set; }
        public int Lotacao{ get; set; }

        
    }


}
