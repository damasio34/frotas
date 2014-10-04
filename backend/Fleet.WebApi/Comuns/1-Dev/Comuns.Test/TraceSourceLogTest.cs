using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vvs.Infraestrutura.Comuns.Implementacao.Logger;
using Vvs.Infraestrutura.Comuns.Logger;

namespace Vvs.Infraestrutura.Comuns.Tests
{
    [TestClass]
    public class TraceSourceLogTest
    {
        private ILogger _logger;

        [TestInitialize()]
        public void Initialize()
        {
            _logger = new TraceSourceLogFactory().Create();
            _logger = new TraceSourceLogFactory().Create("Infraestrutura.Logger");
        }

        [TestMethod]
        public void LogInfoComParametros_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "1");
            _logger.LogInfo("TesteInfo", "parametro1", "parametro1");
        }

        [TestMethod]
        public void LogWarningComParametros_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "2");
            _logger.LogWarning("TesteInfo", "parametro1", "parametro1");
        }

        [TestMethod]
        public void LogErrorComParametros_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "3");
            _logger.LogError("TesteInfo", "parametro1", "parametro1");
        }

        [TestMethod]
        public void LogErrorComException_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "4");
            _logger.LogError("TesteInfo", new Exception(""));
        }

        [TestMethod]
        public void DebugComParametros_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "5");
            _logger.Debug("TesteInfo", "parametro1", "parametro1");
        }

        [TestMethod]
        public void DebugComException_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "6");
            _logger.Debug("TesteInfo", new Exception(""));
        }

        [TestMethod]
        public void Debug_Sucesso()
        {
            object item = "TesteInfor";
            _logger.AddParameter("IdUsuario", "7");
            _logger.Debug(item);
        }

        [TestMethod]
        public void FatalComParametros_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "8");
            _logger.Fatal("TesteInfo", "parametro1", "parametro1");
        }

        [TestMethod]
        public void FatalComException_Sucesso()
        {
            _logger.AddParameter("IdUsuario", "9");
            _logger.Fatal("TesteInfo", new Exception(""));
        }


    }
}


