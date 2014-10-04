using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens;
using System.Security;
using System.Security.Claims;
using System.ServiceModel;
using Vvs.Infraestrutura.Security.Authentication;
using Vvs.Infraestrutura.Security.Authentication.CPlusAnywhere;
using ClaimTypes = Vvs.Infraestrutura.Security.Claims.ClaimTypes;

namespace Vvs.Infraestrutura.Security.STS.Tokens
{
    /// <summary>
    ///     Um handler é usado para serializar e validar Tokens encontrados nas mensagens WS-Trust.
    /// </summary>
    public class VvsSecurityTokenHandler : UserNameSecurityTokenHandler
    {

        #region ' Base Method Override '

        public override bool CanValidateToken
        {
            get { return true; }
        }

        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token)
        {
            try
            {

                var usernameToken = token as UserNameSecurityToken;
                if (usernameToken == null) throw new SecurityException("Token inválido");

                var credenciais = new VvsUserNameSecurityTokenWrapper(usernameToken) as IVvsCredentials;

                // Autentica token.
                if (!Autenticador.Autenticar(credenciais))
                {
                    throw new FaultException("Grupo Empresa/Usuario/Senha inválido.");
                }

                // Cria Identity
                var claims = new[]
                {
                    new Claim(ClaimTypes.GrupoEmpresa.Id, credenciais.IdGrupoEmpresa.ToString("D")),
                    new Claim(ClaimTypes.Usuario.Login, credenciais.LoginUsuario),
                };
                var identidadeAtual = new ClaimsIdentity(claims);

                return new ReadOnlyCollection<ClaimsIdentity>(new List<ClaimsIdentity>() {identidadeAtual});
            }
            catch (Exception ex)
            {
                throw new FaultException<Exception>(ex,
                    String.Format("Erro @ VvsTokenHandler.ValidateToken: {0}", ex.Message));
            }

        }

        #endregion

    }
}