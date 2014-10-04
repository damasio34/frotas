using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Vvs.Infraestrutura.Security.STS.ErrorHandler
{
    public class ErrorHandler : IErrorHandler
    {

        #region ' IErrorHandler '

        /// <summary>
        ///     Enables error-related processing and returns a value that indicates whether
        ///     the dispatcher aborts the session and the instance context in certain cases.
        /// </summary>
        /// <param name="error">
        ///     The exception thrown during processing
        /// </param>
        /// <returns>
        ///     true if Windows Communication Foundation (WCF) should not abort the session
        ///     (if there is one) and instance context if the instance context is not System.ServiceModel.InstanceContextMode.Single;
        ///     otherwise, false. The default is false.
        /// </returns>
        public bool HandleError(Exception error)
        {
            return false;
        }

        /// <summary>
        ///     Enables the creation of a custom System.ServiceModel.FaultException&lt;TDetail&gt;
        ///     that is returned from an exception in the course of a service method.
        /// </summary>
        /// <param name="error">
        ///     The System.Exception object thrown in the course of the service operation.
        /// </param>
        /// <param name="version">
        ///     The SOAP version of the message.
        /// </param>
        /// <param name="fault">
        ///     The System.ServiceModel.Channels.Message object that is returned to the client,
        ///     or service, in the duplex case.
        /// </param>
        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            Object xy = null;
        }

        #endregion

    }
}