

using Vvs.Infraestrutura.Comuns.Logger;

namespace Vvs.Infraestrutura.Comuns.Implementacao.Logger
{
    public class TraceSourceLogFactory
        :ILoggerFactory
    {
        public ILogger Create()
        {
            return new TraceSourceLog();
        }

        public ILogger Create(string nomeAplicacao)
        {
            return new TraceSourceLog(nomeAplicacao);
        }
    }
}
