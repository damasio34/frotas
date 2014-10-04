using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class QuilometroTest
    {

        [TestCategory("Conversores de Quilometro")]
        [TestMethod]
        public void ConverteParaHectometro()
        {
            Quilometro kilometro = new Quilometro(1);

            Hectometro metroCast = kilometro;
            Hectometro metroConstructor = new Hectometro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 10, metroCast.Valor);
            Assert.AreEqual(metroCast.Valor, 10);
            Assert.AreEqual(metroConstructor.Valor, metroCast.Valor);
            Assert.AreEqual(kilometro.ValorFormatado, "1 km");
            Assert.AreEqual(metroCast.ValorFormatado, "10 hm");
        }

        [TestMethod]
        [TestCategory("Conversores de Quilometro")]
        public void ConverteParaDecâmetro()
        {
            Quilometro kilometro = new Quilometro(1);

            Decametro metroCast = kilometro;
            Decametro metroConstructor = new Decametro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 100, metroCast.Valor);
            Assert.AreEqual(metroCast.Valor, 100);
            Assert.AreEqual(metroConstructor.Valor, metroCast.Valor);
            Assert.AreEqual(kilometro.ValorFormatado, "1 km");
            Assert.AreEqual(metroCast.ValorFormatado, "100 dam");
        }

        [TestMethod]
        [TestCategory("Conversores de Quilometro")]
        public void ConverteParaMetro()
        {
            Quilometro kilometro = new Quilometro(1);

            Metro metroCast = kilometro;
            Metro metroConstructor = new Metro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 1000, metroCast.Valor);
            Assert.AreEqual(metroCast.Valor, 1000);
            Assert.AreEqual(metroConstructor.Valor, metroCast.Valor);
            Assert.AreEqual(kilometro.ValorFormatado, "1 km");
            Assert.AreEqual(metroCast.ValorFormatado, "1000 m");
        }

        [TestMethod]
        [TestCategory("Conversores de Quilometro")]
        public void ConverteParaDecimetro()
        {
            Quilometro kilometro = new Quilometro(1);

            Decimetro decimetroCast = kilometro;
            Decimetro decimetroConstructor = new Decimetro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 10000, decimetroCast.Valor);
            Assert.AreEqual(decimetroCast.Valor, 10000);
            Assert.AreEqual(decimetroConstructor.Valor, decimetroCast.Valor);
            Assert.AreEqual(decimetroCast.ValorFormatado, "10000 dm");
        }

        [TestMethod]
        [TestCategory("Conversores de Quilometro")]
        public void ConverteParaCentimetro()
        {
            Quilometro kilometro = new Quilometro(1);

            Centimetro centimetroCast = kilometro;
            Centimetro centimetroConstructor = new Centimetro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 100000, centimetroCast.Valor);
            Assert.AreEqual(centimetroCast.Valor, 100000);
            Assert.AreEqual(centimetroConstructor.Valor, centimetroCast.Valor);
            Assert.AreEqual(centimetroCast.ValorFormatado, "100000 cm");
        }

        [TestMethod]
        [TestCategory("Conversores de Quilometro")]
        public void ConverteParaMilimetro()
        {
            Quilometro kilometro = new Quilometro(1);

            Milimetro milimetroCast = kilometro;
            Milimetro milimetroConstructor = new Milimetro(kilometro);

            //1 kilometro = 1000 Metros
            Assert.AreEqual(kilometro.Valor * 1000000, milimetroCast.Valor);
            Assert.AreEqual(milimetroCast.Valor, 1000000);
            Assert.AreEqual(milimetroConstructor.Valor, milimetroCast.Valor);
            Assert.AreEqual(milimetroCast.ValorFormatado, "1000000 mm");

        }

    }

}

