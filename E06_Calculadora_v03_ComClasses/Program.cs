using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E06_Calculadora_v03_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            //Calculator calc01 = new Calculator(05, 25, "1");

            //calc01.Calculate();
            //calc01.ShowResult();

            Calculator calc02 = new Calculator();

            calc02.Operator = CalculatorUtility.ShowMenu();

            if (calc02.Operator != "0")
            {
                calc02.AskData();
                calc02.Calculate();
                calc02.ShowResult();
            }

            Utility.TerminateConsole();
        }
    }
}
