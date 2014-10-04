using Kereta.Web.Api.Configurations;
using Kereta.Web.Api.Dto;
using Kereta.Web.Api.Mock;
using Nancy;

namespace Kereta.Web.Api.Modules.Frota
{
    public static class ResponseExtensions
    {

        public static Nancy.Response To(this IResponseFormatter response, AppResponse resposta)
        {
            var status = resposta.HasOk ? HttpStatusCode.OK : HttpStatusCode.BadRequest;
            return response.AsJson(resposta, status);
        }
    }

    public class CategoriaDoVeiculoModule : NancyModule
    {
        private DataStore DataStore;

        public CategoriaDoVeiculoModule(DataStore dataStore)
            : base("frota/categoriasDeVeiculos")
        {
            DataStore = dataStore;

            Get["/"] = parameters =>
            {
                DataStore.CategoriasDoVeiculo.Add(new CategoriaDoVeiculoDto());
                var resposta = AppResponse.Ok(DataStore.CategoriasDoVeiculo, "Operação realizada com sucesso");
                return Response.To(resposta);

            };
        }
    }
}
