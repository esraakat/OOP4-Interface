using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit payment plan has been added.");
        }
    }
}
