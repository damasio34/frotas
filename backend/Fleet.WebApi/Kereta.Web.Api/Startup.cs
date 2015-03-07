using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Kereta.Infraestrutura.Data;
using Microsoft.Owin.Cors;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Vvs.Domain.Seedwork;
using Vvs.Domain.Seedwork.Repositorios;
using Vvs.Domain.Seedwork.UnitOfWork;
using Kereta.Dominio.Documentacao;

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

            //var typeEntity = typeof(EntityBase);
            //var types = Assembly.Load("Kereta").GetTypes().ToArray();
            //var types2 = types.Where(a => a.BaseType != null && a.BaseType.Name == "EntityBase");

            kernel.Bind<IUnitOfWork>().To<KeretaUnitOfWork>();

            kernel.Bind<IRepository<Modelo>>().To<Repository<Modelo>>();
            kernel.Bind<IRepository<GravidadeDeQualificacao>>().To<Repository<GravidadeDeQualificacao>>();
            kernel.Bind<IRepository<SubSistema>>().To<Repository<SubSistema>>();
            kernel.Bind<IRepository<Sistema>>().To<Repository<Sistema>>();
            kernel.Bind<IRepository<Marca>>().To<Repository<Marca>>();
            kernel.Bind<IRepository<CentroDeCusto>>().To<Repository<CentroDeCusto>>();
            kernel.Bind<IRepository<FuncaoDoColaborador>>().To<Repository<FuncaoDoColaborador>>();
            kernel.Bind<IRepository<Colaborador>>().To<Repository<Colaborador>>();
            kernel.Bind<IRepository<Veiculo>>().To<Repository<Veiculo>>();
            kernel.Bind<IRepository<Categoria>>().To<Repository<Categoria>>();

            
            return kernel;
        }
    }
}
