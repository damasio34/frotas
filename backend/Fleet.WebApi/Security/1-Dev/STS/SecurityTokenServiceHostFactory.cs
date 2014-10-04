using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Security;

namespace Vvs.Infraestrutura.Security.STS
{
    public class SecurityTokenServiceHostFactory : ServiceHostFactoryBase
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            var host = new WSTrustServiceHost(new SecurityTokenServiceConfiguration(), baseAddresses);
            return host;

        }
    }
}