using System.IdentityModel;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using Vvs.Infraestrutura.Security.Cryptography;
using ClaimTypes = Vvs.Infraestrutura.Security.Claims.ClaimTypes;

namespace Vvs.Infraestrutura.Security.STS
{
    public class SecurityTokenService : System.IdentityModel.SecurityTokenService
    {

        #region ' Constructor '

        public SecurityTokenService(SecurityTokenServiceConfiguration securityTokenServiceConfiguration) : base(securityTokenServiceConfiguration)
        {
        }

        #endregion


        #region ' Abstract Methods Implementation '

        /// <summary>
        ///     Cria e retorna uma instância da classe Scope, que contém toda a configuração necessária 
        ///     para gerar o retorno para a respectiva aplicação (relying party).
        ///     Neste método é possível verificar quais são as chaves de criptografia que serão utilizadas, 
        ///     baseando-se no endereço da relying party.
        /// </summary>
        /// <remarks>
        ///     Read more: http://www.linhadecodigo.com.br/artigo/2993/autenticacao-via-claims-no-wcf.aspx#ixzz2oKTavumy
        /// </remarks>
        protected override Scope GetScope(ClaimsPrincipal principal, RequestSecurityToken request)
        {
            var scope = new Scope(request.AppliesTo.Uri.AbsoluteUri)
            {
                //certificado do RP (um para cada RP)
                EncryptingCredentials = GetCredentialsForAppliesTo(request.AppliesTo),

                //Certificado do STS
                SigningCredentials = this.SecurityTokenServiceConfiguration.SigningCredentials,
            };

            return scope;
        }

        /// <summary>
        ///     Método que retorna a coleção de claims que serão incluidos no token emitido.
        /// </summary>  
        /// <remarks>
        ///     Neste passo o usuário já foi autenticado.
        /// </remarks>
        protected override ClaimsIdentity GetOutputClaimsIdentity(ClaimsPrincipal principal, RequestSecurityToken request, Scope scope)
        {
            if (principal == null) throw new InvalidRequestException("The caller's principal is null.");

            // Determina Dados
            //var idGrupoEmpresa = principal.Claims.Where(c => c.Type == ClaimTypes.IdGrupoEmpresa).Select(c => 0 + c.Value).SingleOrDefault();
            //var login = principal.Claims.Where(c => c.Type == ClaimTypes.Login).Select(c => 0 + c.Value).SingleOrDefault();

            // Popula Claims Adicionais.
            var claims = new Claim[]
            {
                // ToDo: popular com claims adicionais.
            };

            var identity = new ClaimsIdentity(principal.Identities.First(), claims, "Vvs.Infraestrutura.Seguranca.STS",
                ClaimTypes.Usuario.Nome, System.Security.Claims.ClaimTypes.Role);


            return identity;
        }

        #endregion

        /// <summary>
        ///     Recupera instância do Certificado do RP específico.
        /// </summary>
        /// <remarks>
        ///     Cada Relying Party precisa ter um Certificado próprio.
        /// </remarks>
        protected EncryptingCredentials GetCredentialsForAppliesTo(EndpointReference endpointAddress)
        {
            string nomeCertificado;

            // Determina Certificado de acordo com o RP;
            switch (endpointAddress.Uri.AbsoluteUri)
            {
                //case "http://exemplo.com/servico.svc":
                //    nomeCertificado = "CN=Something";
                //    break;

                default:
                    nomeCertificado = STS.SecurityTokenServiceConfiguration.NomeCertificadoSTS;
                    break;
            }

            return
                new X509EncryptingCredentials(CertificateUtil.GetCertificate(StoreName.TrustedPeople, StoreLocation.LocalMachine, nomeCertificado));
        }

    }
}