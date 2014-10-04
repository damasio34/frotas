using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Cubica;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Quadrada;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class ComprimentoTest
    {

        [TestCategory("Operação entre Comprimentos")]
        [TestMethod]
        public void SomatorioDeTodosOsComprimentos()
        {
            var umKm = new Quilometro(1);
            var umHectometro = new Hectometro(1);
            var umDecametro = new Decametro(1);
            var umMetro = new Metro(1);
            var umDecimetro = new Decimetro(1);
            var umCentimetro = new Centimetro(1);
            var umMilimetro = new Milimetro(1);

            Metro somatorioEmMetro = umKm + umHectometro + umDecametro + umMetro + umDecimetro + umCentimetro + umMilimetro;

            Assert.AreEqual(somatorioEmMetro.Valor, 1111.111M);
        }

        [TestMethod]
        [TestCategory("Operação entre Comprimentos")]
        public void SubtracaoEntreTodosOsComprimentos()
        {
            var umKm = new Quilometro(1);
            var umHectometro = new Hectometro(1);
            var umDecametro = new Decametro(1);
            var umMetro = new Metro(1);
            var umDecimetro = new Decimetro(1);
            var umCentimetro = new Centimetro(1);
            var umMilimetro = new Milimetro(1);

            Metro subtracaoEmMetros = umKm;
            subtracaoEmMetros -= umHectometro;
            subtracaoEmMetros -= umDecametro;
            subtracaoEmMetros -= umMetro;
            subtracaoEmMetros -= umDecimetro;
            subtracaoEmMetros -= umCentimetro;
            subtracaoEmMetros -= umMilimetro;

            Metro subtracaoDeUmaSoVez = umKm - umHectometro - umDecametro - umMetro - umDecimetro - umCentimetro - umMilimetro;

            Assert.AreEqual(subtracaoEmMetros.Valor, 888.889M);
            Assert.AreEqual(subtracaoEmMetros.Valor, subtracaoDeUmaSoVez.Valor);
        }

        [TestCategory("Operação entre Comprimentos")]
        [TestMethod]
        public void ProdutoEDivisaoEntreDoisComprimentos()
        {

            var larguraDecametro = new Decametro(1);
            var alturaDecimetro = new Decimetro(20);

            MetroQuadrado areaQuadrada = larguraDecametro * alturaDecimetro;

            Decametro larguraMetroRetorno = areaQuadrada / alturaDecimetro;

            Assert.AreEqual(areaQuadrada.Valor, 20M);
            Assert.AreEqual(areaQuadrada.ValorFormatado, "20,0 m²");
            Assert.AreEqual(larguraDecametro.Valor, larguraMetroRetorno.Valor);

        }

        [TestMethod]
        [TestCategory("Operação entre Comprimentos")]
        public void ProdutoEDivisaoEntreTresComprimentos()
        {

            var larguraDecametro = new Decametro(1);//Igual a 10 metros
            var alturaDecimetro = new Decimetro(20);//Igual a 2 metros
            var profundidadeCentimetro = new Centimetro(200); //Igual a 2 metros

            //Resultado = 40 m³
            Volume areaCubica = larguraDecametro * alturaDecimetro * profundidadeCentimetro;

            //Resultado = 20 m²
            Area areaQuadrada = larguraDecametro * alturaDecimetro;

            //Resultado = 20 m
            Area areaProvaDosNove = areaCubica / profundidadeCentimetro;

            Assert.AreEqual(areaCubica.Valor, 40M);
            Assert.AreEqual(areaQuadrada.Valor, 20M);
            Assert.AreEqual(areaProvaDosNove.Valor, 20M);
            Assert.AreEqual(areaProvaDosNove.Valor, areaQuadrada.Valor);

        }



    }

}

