using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using Vvs.Infraestrutura.Security.Cryptography;

namespace Vvs.Infraestrutura.Security.STS
{
    public class SecurityTokenServiceConfiguration: System.IdentityModel.Configuration.SecurityTokenServiceConfiguration
    {

        #region ' Constructor '

        //ToDo: migrar configuração para Config File.

        public SecurityTokenServiceConfiguration() : base()
        {
            this.TokenIssuerName = ConfigurationManager.AppSettings.Get("vvsSTS:IssuerName"); 
            this.SecurityTokenService = typeof(SecurityTokenService);
            this.SigningCredentials = new X509SigningCredentials(CertificateUtil.GetCertificate(StoreName.TrustedPeople, StoreLocation.LocalMachine, NomeCertificadoSTS));
        }

        #endregion

        /// <summary>
        ///     Nome do certificado a ser utilizado nas respostas do STS.
        /// </summary>
        internal static String NomeCertificadoSTS
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("vvsSTS:NomeCertificado");
            }
        }


    }
}