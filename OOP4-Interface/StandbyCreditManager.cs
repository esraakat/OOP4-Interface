using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    class StandbyCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Standy Credit payment plan has been added");
        }
    }
}
