using System;
using System.Diagnostics.Contracts;
using log4net;
using Vvs.Infraestrutura.Comuns.Logger;

namespace Vvs.Infraestrutura.Comuns.Implementacao.Logger
{
    /// <summary>
    /// Implementação do contrato <see cref="Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Logger.ILogger"/>
    /// utilizando Log4net.
    /// </summary>
    public sealed class TraceSourceLog
        : ILogger
    {
        #region Members

        ILog source;

        #endregion

        #region  Constructor

        public TraceSourceLog()
        {
            GetLogger("Infraestrutura.Logger");
        }

        public TraceSourceLog(string nomeAplicacao)
        {
            GetLogger(nomeAplicacao);
        }

        #endregion

        #region ILogger Members

        private void GetLogger(string nomeAplicacao)
        {
            source = global::log4net.LogManager.GetLogger(nomeAplicacao);
        }

        public void AddParameter(string key, string value)
        {
            Contract.Requires<ArgumentNullException>(key != null, "A propriedade key não pode ser nula");
            Contract.Requires<ArgumentNullException>(key != String.Empty,"A propriedade key não pode ser Empty");

            global::log4net.ThreadContext.Properties[key] = value;
        }

        public void LogInfo(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
                source.InfoFormat(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {

            if (!String.IsNullOrWhiteSpace(message))
                source.WarnFormat(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
                source.ErrorFormat(message, args);
        }

        public void LogError(string message, Exception exception)
        {
            if (!String.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                source.Error(message, exception);
            }
        }

        public void Debug(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
                source.DebugFormat(message, args);
        }

        public void Debug(string message, Exception exception)
        {
            if (!String.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                source.Debug(message, exception);
            }
        }

        public void Debug(object item)
        {
            if (item != null)
                source.Debug(item);
        }

        public void Fatal(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
                source.FatalFormat(message, args);
        }

        public void Fatal(string message, Exception exception)
        {
            if (!String.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                source.FatalFormat(message, exception);
            }
        }


        #endregion
    }
}
