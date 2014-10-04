using System;
using System.Security;

namespace Vvs.Infraestrutura.Security.Exceptions
{
    /// <summary>
    ///     Exceção que é levantada quando ocorre a tentativa de se ler ou escrever dados de GrupoEmpresas diferente
    ///     da do usuário autenticado.
    /// </summary>
    public class GrupoEmpresaViolationException : SecurityException
    {

        #region ' Constructor '

        public GrupoEmpresaViolationException() : this(null)
        {
        }

        public GrupoEmpresaViolationException(Exception innerException) 
            : base("Tentativa de leitura/escrita de dados de outras empresas (seriais) identificada.", innerException)
        {
        }

        #endregion
    }
}
