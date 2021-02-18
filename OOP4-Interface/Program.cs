using System;
using System.Collections.Generic;

namespace OOP4_Interface
{
    class Program 
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceManager = new PersonalFinanceCreditManager();
            personalFinanceManager.Calculate();

            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();
            Console.WriteLine("\n");

            ILoggerService dataBaseLOggerService = new DataBaseLoggerService();
            ILoggerService fileBaseLoggerService = new FileBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(mortgageLoanManager, dataBaseLOggerService);
            applicationManager.Apply(vehicleLoanManager, fileBaseLoggerService);
            applicationManager.Apply(mortgageLoanManager, smsLoggerService);
            Console.WriteLine("\n");

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceManager, vehicleLoanManager};
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, dataBaseLOggerService };
            applicationManager.PreliminaryInforming(credits, loggers);

        }
    }
}
