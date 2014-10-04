using System.Collections.Generic;
using System.Security.Claims;
using ClaimTypes = Vvs.Infraestrutura.Security.Claims.ClaimTypes;

namespace Vvs.Infraestrutura.Security.Principal
{
    public class VvsIdentity : ClaimsIdentity, IVvsIdentity
    {
        public new const string DefaultNameClaimType = ClaimTypes.Usuario.Nome;


        #region ' Construtores '

        public VvsIdentity(IEnumerable<Claim> claims, string authenticationType) : base(claims, authenticationType) { }

        #endregion

        public string GrupoEmpresa
        {
            get
            {
                var claim = this.GetClaim("GrupoEmpresa_Nome");
                return claim != null ? claim.Value : null;
            }

        }

        public override string Name
        {
            get
            {
                var claim = this.GetClaim(DefaultNameClaimType);
                return claim != null ? claim.Value : null;
            }
        }
    }
}
