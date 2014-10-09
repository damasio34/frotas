using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Infraestrutura.Data;
using Microsoft.Owin.Cors;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Vvs.Domain.Seedwork.Repositorios;
using Vvs.Domain.Seedwork.UnitOfWork;

namespace Kereta.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            if (app == null) throw new ArgumentNullException("app");
            
            // CORS
            app.UseCors(CorsOptions.AllowAll);

            // Web API
            //var httpConfig = GlobalConfiguration.Configuration;
            var httpConfig = new HttpConfiguration();

            WebApiConfig.Register(httpConfig);
            httpConfig.EnsureInitialized();

            //Config Web Api Com Ninject
            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(httpConfig);

#if DEBUG

            app.UseErrorPage();
            app.UseWelcomePage("/");

#endif

        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IUnitOfWork>().To<KeretaUnitOfWork>();
            kernel.Bind<IRepository<Modelo>>().To<Repository<Modelo>>();
            kernel.Bind<IRepository<Marca>>().To<Repository<Marca>>();
            return kernel;
        }
    }
}
