using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    //method injection - İnject what credit type and logger that method will take
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        
        //alternative - more useful
        public void PreliminaryInforming(List<ICreditManager> credits, List<ILoggerService> loggers) //It is not clear how many I will choose.
        {
            foreach (ICreditManager credit in credits) //calculate for every credits in list.
            {
                credit.Calculate();
            }
            foreach (ILoggerService log in loggers)
            {
                log.Log();
            }

        }



    }
}
