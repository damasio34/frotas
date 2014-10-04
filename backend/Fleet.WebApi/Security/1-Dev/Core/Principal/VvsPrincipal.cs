using System;
using System.Security.Claims;
using ClaimTypes = Vvs.Infraestrutura.Security.Claims.ClaimTypes;

namespace Vvs.Infraestrutura.Security.Principal
{
    public class VvsPrincipal : ClaimsPrincipal, IVvsPrincipal
    {

        #region ' Construtor '

        public VvsPrincipal(VvsIdentity identity) : base(identity) { }

        #endregion

        #region ' IVvsPrincipal '

        public int? IdGrupoEmpresa
        {
            get
            {

                var claim = this.GetClaim(ClaimTypes.GrupoEmpresa.Id);
                return claim != null ? int.Parse(claim.Value) : (int?)null;
            }
        }

        public Guid? IdUsuario
        {
            get
            {
                var claim = this.GetClaim(ClaimTypes.Usuario.Id);
                return claim != null ? Guid.Parse(claim.Value) : (Guid?)null;
            }
        }

        #endregion

        /// <summary>
        ///     Gets the current claims principal.
        /// </summary>
        /// <returns>
        ///     The current claims principal.
        /// </returns>
        public new static VvsPrincipal Current
        {
            get
            {
                return ClaimsPrincipal.Current as VvsPrincipal ?? new VvsPrincipal(new VvsIdentity(ClaimsPrincipal.Current.Claims, "none"));
            }
        }

        public static VvsPrincipal Create(string nomeUsuario, int idGrupoEmpresa, Guid idUsuario, string authenticationType)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Usuario.Id, idUsuario.ToString("D")),
                new Claim(ClaimTypes.GrupoEmpresa.Id, idGrupoEmpresa.ToString("D")),
                new Claim(ClaimTypes.Usuario.Nome, nomeUsuario),
            };

            var identity = new VvsIdentity(claims, authenticationType);
            return new VvsPrincipal(identity);
        }

    }
}
