namespace ExceptionHandlingBlock
{
    using System;

    using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
    using Microsoft.Practices.EnterpriseLibrary.Logging;

    public class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            try
            {
                DoStuff();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cought application leve exception!");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        private static void MyExceptionCode()
        {
            Console.WriteLine("Trowing exception");
            throw new Exception("My basic exception!");

            Console.WriteLine("Passed exception");
        }

        private static void DoStuff()
        {
            // IoC
            ExceptionPolicyFactory policyFactory = new ExceptionPolicyFactory();
            var exceptionManager = policyFactory.CreateManager();
            exceptionManager.Process(MyExceptionCode, "Policy");

            //LogWriterFactory logWriterFactory = new LogWriterFactory();
            //var log = logWriterFactory.Create();

            //var configSource = ConfigurationSourceFactory.Create();

            //Logger.SetLogWriter(new LogWriterFactory(configSource).Create());
            //ExceptionPolicy.SetExceptionManager(new ExceptionPolicyFactory(configSource).CreateManager());
        }

        #endregion
    }
}