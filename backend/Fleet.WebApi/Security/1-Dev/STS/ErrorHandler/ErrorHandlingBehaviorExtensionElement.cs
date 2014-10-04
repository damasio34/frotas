using System;
using System.ServiceModel.Configuration;

namespace Vvs.Infraestrutura.Security.STS.ErrorHandler
{
    public class ErrorHandlingBehaviorExtensionElement : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new ErrorHandlingServiceBehavior();
        }

        public override Type BehaviorType
        {
            get { return typeof (ErrorHandlingServiceBehavior); }
        }
    }
}