using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Refectory;

namespace Kereta.Infraestrutura.Data.Migrations
{
    public class SeedDatabase
    {
        public void Seed(DbContext context)
        {
            var marcas = CriarMarcas().ToList();
            context.Update(marcas);

            //context.Update(CriarModelos(marcas).ToArray());
        }

        private IEnumerable<Marca> CriarMarcas()
        {
            yield return Marca.Criar("Agrale").ChangeIdentityAndReturn(Guid.Parse("19a08312-258b-4113-ad8d-712335760dd7"));
            yield return Marca.Criar("Astra").ChangeIdentityAndReturn(Guid.Parse("994a655d-826f-41d7-82cb-5b4d0086ea47"));
            yield return Marca.Criar("Athos").ChangeIdentityAndReturn(Guid.Parse("0c0c564b-34ad-4436-ac28-8f6d5bcc59d8"));
            yield return Marca.Criar("Autokraz").ChangeIdentityAndReturn(Guid.Parse("4c8443b3-a971-4257-8157-82d3161c09b0"));
            yield return Marca.Criar("BMC").ChangeIdentityAndReturn(Guid.Parse("75762c4a-079f-486f-a8a7-5feff29888cd"));
            yield return Marca.Criar("Caterpillar").ChangeIdentityAndReturn(Guid.Parse("d43fbcdd-c8af-47a6-9795-3c155c517699"));

        }

        private IEnumerable<Modelo> CriarModelos(List<Marca> marcas)
        {
            foreach (var marca in marcas)
            {
                yield return new Modelo(marca, 10, "Modelo 1").GenerateIdentityAndReturn();
                yield return new Modelo(marca, 10, "Modelo 2").GenerateIdentityAndReturn();
            }
        }
    }


}
