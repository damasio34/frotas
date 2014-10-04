using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Vvs.Infraestrutura.Comuns.Security;

namespace Vvs.Infraestrutura.Comuns.Tests
{
    [TestClass]
    public class SecurityTest
    {
        [TestMethod]
        public void ApplicactionContext_Sucesso()
        {
            var mock = new Mock<IApplicationContext>();

            var idUsuario = new Guid();

            mock.SetupGet(m => m.IdUsuario).Returns(idUsuario);

            var applicationContext = (IApplicationContext)mock.Object;

            Assert.AreEqual(applicationContext.IdUsuario, idUsuario,"O Guid do usuário passado para o mock não é igual a propriedade do ApplicationContext");

        }

     
    }
}
