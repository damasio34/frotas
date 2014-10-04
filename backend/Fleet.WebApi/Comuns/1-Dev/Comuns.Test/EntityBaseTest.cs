using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Comuns.Implementacao.Validator;
using Vvs.Infraestrutura.Comuns.Tests.Stub;
using Vvs.Infraestrutura.Comuns.Validator;

namespace Vvs.Infraestrutura.Comuns.Tests
{
    [TestClass]
    public class EntityBaseTest
    {

        [TestInitialize()]
        public void Initialize()
        {
            EntityValidatorFactory.SetCurrent(new DataAnnotationsEntityValidatorFactory());
        }

        [TestMethod]
        public void EntidadeValidavelTest_Sucesso()
        {
            EntidadeValidavelStub c = new EntidadeValidavelStub();

            bool isValid = c.IsValid();

            var erros = c.Validations;

            Assert.IsFalse(isValid);
            Assert.IsTrue(erros.Any());

            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EntidadeNaoValidavelTest_Sucesso()
        {
            EntidadeNaoValidavelStub c = new EntidadeNaoValidavelStub();

            bool isValid = c.IsValid();

            Assert.IsFalse(isValid);
            Assert.Fail("Uma exception deve ocorrer quando o método isvalid for chamado de uma entidade que herde de EntityBase e nãi implemente IValidatabloeObject");
        }
    }
}
