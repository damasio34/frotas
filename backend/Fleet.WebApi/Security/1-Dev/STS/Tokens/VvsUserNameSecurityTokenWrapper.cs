using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using Vvs.Infraestrutura.Security.Authentication;

namespace Vvs.Infraestrutura.Security.STS.Tokens
{
    /// <summary>
    ///     Wrapper para recuperar os dados e autenticação da VVS a partir de um UserNameSecurityToken
    /// </summary>
    public class VvsUserNameSecurityTokenWrapper : IVvsCredentials
    {

        public UserNameSecurityToken UserNameSecurityToken { get; private set; }
        private readonly int _idGrupoEmpresa;
        private readonly string _loginUsuario;

        #region ' Constructor '

        public VvsUserNameSecurityTokenWrapper(UserNameSecurityToken userNameSecurityToken)
        {
            var regex = new Regex(@"\A\d+\|\w+"); // e.g.: '0000|login'

            if (!regex.IsMatch(userNameSecurityToken.UserName)) 
                throw new InvalidRequestException("UserName informado no formato incorreto. Informar no formato '0000|{login}', onde '0000' é o id do grupo empresa.");

            this.UserNameSecurityToken = userNameSecurityToken;

            var authDataArray = userNameSecurityToken.UserName.Split('|');
            _idGrupoEmpresa = int.Parse("0" + authDataArray[0]);
            _loginUsuario = authDataArray[1];

        }

        #endregion

        #region ' IVvsCredentials '

        public int IdGrupoEmpresa
        {
            get { return _idGrupoEmpresa; }
        }

        public string LoginUsuario
        {
            get { return _loginUsuario; }
        }

        public string Senha
        {
            get { return this.UserNameSecurityToken.Password; }
        }

        #endregion

    }
}