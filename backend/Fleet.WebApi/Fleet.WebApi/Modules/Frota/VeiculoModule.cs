using Kereta.Web.Api.Dto;
using Kereta.Web.Api.Mock;
using Nancy;

namespace Kereta.Web.Api.Modules.Frota
{
    public class VeiculoModule : NancyModule
    {
        private DataStore DataStore;

        public VeiculoModule(DataStore dataStore)
            : base("veiculos")
        {
            DataStore = dataStore;

            Get["/"] = parameters =>
            {
                DataStore.Veiculos.Add(new VeiculoDto());
                return Response.AsText("Teste");

            };
        }
    }
}
