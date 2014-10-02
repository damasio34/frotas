using Fleet.WebApi.Dto;
using Fleet.WebApi.Mock;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fleet.WebApi.Modules
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
