namespace Vvs.Infraestrutura.Comuns.Logger
{
    /// <summary>
    /// Contrato base para a fábrica de Loggers
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger Create(string nomeAplicacao);
        ILogger Create();
    }
}
