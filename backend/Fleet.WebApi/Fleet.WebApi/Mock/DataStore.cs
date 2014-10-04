using System.Collections.Generic;
using System.Linq;
using Kereta.Web.Api.Dto;

namespace Kereta.Web.Api.Mock
{

    public class DataStore 
    {
        public DataStore()
        {
            Veiculos = new List<VeiculoDto>();
            CategoriasDoVeiculo = CriarCategoriasIniciais().ToList();
        }

        private IEnumerable<CategoriaDoVeiculoDto> CriarCategoriasIniciais()
        {
            yield return new CategoriaDoVeiculoDto() { Nome = "Caminhão Pesado" };
        }
        public List<VeiculoDto> Veiculos { get; set; }
        public List<CategoriaDoVeiculoDto> CategoriasDoVeiculo { get; set; }
    }

}
