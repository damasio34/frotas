using System.Linq;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Web.Api.Dto;
using Kereta.Web.Api.Mock;
using Nancy;
using Vvs.Domain.Seedwork.Repositorios;

namespace Kereta.Web.Api.Modules.Frota
{
    public class VeiculoModule : NancyModule
    {
        private DataStore DataStore;

        public VeiculoModule(DataStore dataStore, IRepository<Marca> repository )
            : base("veiculos")
        {
            DataStore = dataStore;

            var x = repository.Listar().ToList();

            Get["/"] = parameters =>
            {
                DataStore.Veiculos.Add(new VeiculoDto());
                return Response.AsText("Teste");

            };
        }
    }
}
