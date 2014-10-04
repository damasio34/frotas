using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class HectometroTest
    {

        [TestCategory("Conversores de Hectometro")]
        [TestMethod]
        public void ConverteParaQuilometro()
        {
            Hectometro hectometro = new Hectometro(10);

            Quilometro quilometroCast = hectometro;
            Quilometro quilometroConstructor = new Quilometro(hectometro);

            //10 hm = 1 Km
            Assert.AreEqual(hectometro.Valor / 10, quilometroCast.Valor);
            Assert.AreEqual(quilometroCast.Valor, 1M);
            Assert.AreEqual(quilometroConstructor.Valor, quilometroCast.Valor);
            Assert.AreEqual(hectometro.ValorFormatado, "10 hm");
            Assert.AreEqual(quilometroCast.ValorFormatado, "1 km");
        }



    }

}

