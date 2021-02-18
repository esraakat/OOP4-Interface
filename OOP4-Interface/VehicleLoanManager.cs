using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit payment plan has been added.");
        }
    }
}
