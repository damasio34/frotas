using System;
using System.Security.Principal;

namespace Vvs.Infraestrutura.Security.Principal
{
    /// <summary>
    ///     A principal object represents the security context of the user 
    ///     on whose behalf the code is running, including that user's 
    ///     identity (IIdentity) and any roles to which they belong.
    /// </summary>
    public interface IVvsPrincipal : IPrincipal
    {
        int? IdGrupoEmpresa { get; }
        Guid? IdUsuario { get; }
    }

}
