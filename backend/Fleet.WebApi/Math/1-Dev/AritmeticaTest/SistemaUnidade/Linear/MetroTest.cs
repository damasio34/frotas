
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class MetroTest
    {
       
        [TestMethod]
        [TestCategory("Conversores de Metro")]
        public void ConverteParaDecametro()
        {
            Metro metro = new Metro(1);

            Decametro decametroCast = metro;
            Decametro decametroConstructor = new Decametro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor / 10, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 0.1M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "0,1 dam");
        }

        [TestMethod]
        [TestCategory("Conversores de Metro")]
        public void ConverteParaHectometro()
        {
            Metro metro = new Metro(1);

            Hectometro decametroCast = metro;
            Hectometro decametroConstructor = new Hectometro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor / 100, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 0.01M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "0,01 hm");
        }

        [TestCategory("Conversores de Metro")]
        [TestMethod]
        public void ConverteParaQuilometro()
        {
            Metro metro = new Metro(1);

            Quilometro decametroCast = metro;
            Quilometro decametroConstructor = new Quilometro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor / 1000, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 0.001M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "0,001 km");
        }

        [TestCategory("Conversores de Metro")]
        [TestMethod]
        public void ConverteParaDecimetro()
        {
            Metro metro = new Metro(1);

            Decimetro decametroCast = metro;
            Decimetro decametroConstructor = new Decimetro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor * 10, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 10M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "10 dm");
        }

        [TestCategory("Conversores de Metro")]
        [TestMethod]
        public void ConverteParaCentimetro()
        {
            Metro metro = new Metro(1);

            Centimetro decametroCast = metro;
            Centimetro decametroConstructor = new Centimetro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor * 100, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 100M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "100 cm");
        }

        [TestCategory("Conversores de Metro")]
        [TestMethod]
        public void ConverteParaMilimetro()
        {
            Metro metro = new Metro(1);

            Milimetro decametroCast = metro;
            Milimetro decametroConstructor = new Milimetro(metro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(metro.Valor * 1000, decametroCast.Valor);
            Assert.AreEqual(decametroCast.Valor, 1000M);
            Assert.AreEqual(decametroConstructor.Valor, decametroCast.Valor);
            Assert.AreEqual(metro.ValorFormatado, "1 m");
            Assert.AreEqual(decametroCast.ValorFormatado, "1000 mm");
        }


    }

}

