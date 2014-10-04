using Kereta.Web.Api.Mock;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Kereta.Web.Api.Configurations
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<DataStore>().AsSingleton();
        }
    }
}
