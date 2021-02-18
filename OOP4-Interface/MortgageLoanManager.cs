using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan payment plan has been added.");
        }
    }
}
