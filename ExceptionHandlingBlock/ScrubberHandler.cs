namespace ExceptionHandlingBlock
{
    using System;
    using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;

    // Custom exception handler 
    // replaces corp name with "Customer" string
    [ConfigurationElementType(typeof(CustomHandlerData))]
    internal class ScrubberHandler : IExceptionHandler
    {
        #region Public Methods and Operators

        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            var newException = new Exception(exception.Message.Replace("XYZ Corp", "Customer"));
        }

        #endregion
    }
}