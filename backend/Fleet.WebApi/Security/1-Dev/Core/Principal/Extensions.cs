using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace Vvs.Infraestrutura.Security.Principal
{
    public static class Extensions
    {
        public static Claim GetClaim(this IPrincipal principal, string claimType)
        {
            if (principal == null) throw new ArgumentNullException("principal");

            var claimsPrincipal = (ClaimsPrincipal)principal;

            return GetClaim(claimsPrincipal.Identities.First(), claimType);     //ToDo: verificar se é necessário procurar o claims em outras identities além da primeira.
        }

        public static Claim GetClaim(this IIdentity identity, string claimType)
        {
            if (identity == null) throw new ArgumentNullException("identity");

            var claimsIdentity = (ClaimsIdentity)identity;

            return claimsIdentity.Claims.SingleOrDefault(c => c.Type == claimType);
        }
    }
}
