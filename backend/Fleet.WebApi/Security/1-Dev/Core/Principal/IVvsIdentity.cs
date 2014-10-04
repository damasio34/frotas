using System.Security.Principal;

namespace Vvs.Infraestrutura.Security.Principal
{
    /// <summary>
    ///     An identity object represents the user on whose behalf the code is running.
    /// </summary>
    public interface IVvsIdentity : IIdentity
    {
        string GrupoEmpresa { get; }
    }

}
