using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade.Linear;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class DecametroTest
    {

        [TestCategory("Conversores de Decametro")]
        [TestMethod]
        public void ConverteParaHectometro()
        {
            Decametro decametro = new Decametro(10);

            Hectometro hectometroCast = decametro;
            Hectometro hectometroConstructor = new Hectometro(decametro);

            //10 hm = 1 Km
            Assert.AreEqual(decametro.Valor / 10, hectometroCast.Valor);
            Assert.AreEqual(hectometroCast.Valor, 1M);
            Assert.AreEqual(hectometroConstructor.Valor, hectometroCast.Valor);
            Assert.AreEqual(decametro.ValorFormatado, "10 dam");
            Assert.AreEqual(hectometroCast.ValorFormatado, "1 hm");
        }



    }

}

