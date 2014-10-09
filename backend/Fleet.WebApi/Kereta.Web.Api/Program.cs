using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Kereta.Web.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:9003";

            Console.Title = "Kereta ( alpha )";
            Console.WriteLine("Rest api privada para front-end do Retaguarda");
            Console.WriteLine("Iniciando servidor em {0}...", url);

            Effort.Provider.EffortProviderConfiguration.RegisterProvider();

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Pressione <ENTER> para sair...");
                Console.ReadLine();
            }
        }
    }
}
