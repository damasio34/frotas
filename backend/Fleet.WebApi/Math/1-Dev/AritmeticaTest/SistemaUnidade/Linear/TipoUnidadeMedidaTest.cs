using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Math.Aritmetica.SistemaUnidade;

namespace AritmeticaTest.SistemaUnidade.Linear
{
    [TestClass]
    public class TipoUnidadeMedidaTest
    {

        [TestCategory("Tipo Unidade Medida")]
        [TestMethod]
        public void ValoresUnidadeMedida()
        {
            Assert.AreEqual(1000, Math.Pow(10, (int)TipoUnidadeMedida.Quilometro));
            Assert.AreEqual(100, Math.Pow(10, (int)TipoUnidadeMedida.Hectometro));
            Assert.AreEqual(10, Math.Pow(10, (int)TipoUnidadeMedida.Decametro));
            Assert.AreEqual(1, Math.Pow(10, (int)TipoUnidadeMedida.Metro));
            Assert.AreEqual(0.1, Math.Pow(10, (int)TipoUnidadeMedida.Decimetro));
            Assert.AreEqual(0.01, Math.Pow(10, (int)TipoUnidadeMedida.Centimetro));
            Assert.AreEqual(0.001, Math.Pow(10, (int)TipoUnidadeMedida.Milimetro));
        }





    }

}

