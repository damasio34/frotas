using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Infraestrutura.Data;
using Kereta.Infraestrutura.Data.Unit;
using Kereta.Web.Api.Mock;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Vvs.Domain.Seedwork.Repositorios;
using Vvs.Domain.Seedwork.UnitOfWork;

namespace Kereta.Web.Api.Configurations
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<DataStore>().AsSingleton();
            container.Register<IKeretaUnitOfWork, KeretaUnitOfWork>();
            container.Register<IRepository<Marca>, KeretaRepository<Marca>>();
        }
    }
}
