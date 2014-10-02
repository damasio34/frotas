using Fleet.WebApi.Configurations;
using Fleet.WebApi.Dto;
using Fleet.WebApi.Mock;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fleet.WebApi.Modules
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
