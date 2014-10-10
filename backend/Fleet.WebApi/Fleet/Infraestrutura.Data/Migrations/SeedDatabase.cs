using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Financeiro.CentroDeCustoAgg;
using Kereta.Dominio.Frota.MarcaAgg;
using Kereta.Dominio.Frota.ModeloAgg;
using Kereta.Dominio.Frota.VeiculoAgg;
using Kereta.Dominio.Manutencao.SistemaAgg;
using Kereta.Dominio.Pessoal.Colaborador;
using Kereta.Dominio.Refectory;

namespace Kereta.Infraestrutura.Data.Migrations
{
    public class SeedDatabase
    {
        public void Seed(DbContext context)
        {
            var marcas = CriarMarcas().ToArray();
            context.Update(marcas);

            var modelo1 = new Modelo(marcas.First(), 10, "Modelo 01").ChangeIdentityAndReturn(Guid.Parse("61699CBA-752A-4CDF-8B91-745667B3D76E"));
            var modelo2 = new Modelo(marcas.Last(), 10, "Modelo 02").ChangeIdentityAndReturn(Guid.Parse("D1518251-C31B-4A93-AB4C-225B2F1B6FB0"));

            context.Update(modelo1, modelo2);

            var sistemas = CriarSistemas().ToArray();
            var subSistema = CriarSubSistemas(sistemas).ToArray();

            var centrosDeCusto = CriarCentrosDeCusto().ToArray();

            var funcaoColaborador = CriarFuncoesColaborador().ToArray();

            var colaboradores = CriarColaboradores(funcaoColaborador).ToArray();

            var categorias= CriarCategorias().ToArray();

            var veiculos = CriarVeiculos(modelo1, categorias, centrosDeCusto).ToArray();

            context.Update(sistemas);

            context.Update(subSistema);

            context.Update(centrosDeCusto);

            context.Update(funcaoColaborador);

            context.Update(colaboradores);
            
            context.Update(categorias);

            context.Update(veiculos);

        }

        private IEnumerable<Categoria> CriarCategorias()
        {
            yield return new Categoria("Passeio").ChangeIdentityAndReturn("046C4886-2350-43E6-ABB8-A2F75C002BA1");
            yield return new Categoria("Carga Pesada").ChangeIdentityAndReturn("87842B17-EFF3-4388-AE15-B85E08E2B51D");
            yield return new Categoria("Carga Média").ChangeIdentityAndReturn("23F98340-86A9-45AD-B06A-E1E9D73ECE57");
        }

        private IEnumerable<Veiculo> CriarVeiculos(Modelo modelo, Categoria[] categorias,  CentroDeCusto[] centrosDeCusto)
        {
            foreach (var categoria in categorias)
                foreach (var centroDeCusto in centrosDeCusto)
                    yield return VeiculoFactory.CriarImplemento(modelo, categoria, centroDeCusto);
            
        }

        private IEnumerable<Colaborador> CriarColaboradores(params FuncaoDoColaborador[] funcaoColaborador)
        {
            foreach (var item in funcaoColaborador)
                yield return 
                    new Colaborador(item, "Colaborador " + DateTime.Now.Millisecond)
                    .ChangeIdentityAndReturn(item.Id);
        }

        private IEnumerable<FuncaoDoColaborador> CriarFuncoesColaborador()
        {
            yield return new FuncaoDoColaborador("Motorista", 8).ChangeIdentityAndReturn("48A80DB7-55B5-4650-837A-C84369446233");
            yield return new FuncaoDoColaborador("Borracheiro", 10).ChangeIdentityAndReturn("07044F0F-CEC1-4C8B-9E31-BBBBFCC3CDFB");
            yield return new FuncaoDoColaborador("Gestor", 10).ChangeIdentityAndReturn("B8025B40-6A91-48B7-B512-41389B427CBB");
            yield return new FuncaoDoColaborador("Mecânico", 10).ChangeIdentityAndReturn("F2CF901E-7838-4254-B82E-8BBDF7E977F6");

        }

        private IEnumerable<CentroDeCusto> CriarCentrosDeCusto()
        {
            yield return new CentroDeCusto("Administrativo", "Administrativo").ChangeIdentityAndReturn("DF164EB5-A9FD-4267-A401-01AC6C8CF9C0");
            yield return new CentroDeCusto("Comercial", "Comercial").ChangeIdentityAndReturn("78BBB44D-AAAD-4077-A280-4989183C1D07");
            yield return new CentroDeCusto("Diretoria", "Diretoria").ChangeIdentityAndReturn("1C8597B4-73C3-438C-9706-86DB2E998A13");
            yield return new CentroDeCusto("Oficina", "Oficina").ChangeIdentityAndReturn("900BBF91-ED29-48E2-9646-894725F092B2");
        }

        private IEnumerable<SubSistema> CriarSubSistemas(Sistema[] sistemas)
        {
            foreach (var sistema in sistemas)
                yield return new SubSistema(sistema, "Sub Sistema " + sistema.Id).ChangeIdentityAndReturn(sistema.Id);
        }

        private IEnumerable<Sistema> CriarSistemas()
        {
            yield return new Sistema("Combustíveis").ChangeIdentityAndReturn(Guid.Parse("CA56CFA6-570B-4334-BAD7-5087E6E9A6C6"));
            yield return new Sistema("Elétrico").ChangeIdentityAndReturn(Guid.Parse("8D0FDAFF-EA22-47A0-9748-CA27FC37D12D"));
            yield return new Sistema("Funilaria").ChangeIdentityAndReturn(Guid.Parse("C388C5B0-5674-4BBD-9933-E6E42EACE3FD")); ;
            yield return new Sistema("Mecânico").ChangeIdentityAndReturn(Guid.Parse("3A6A30DC-9057-445C-8735-070C26663D9B")); ;
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
