using D00_Utility;
using System;

namespace E06_Calculadora_v02_ComClasses
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Calculator calculator = new Calculator();

            try
            {

                calculator.Operation = CalculatorUtility.ShowMenu();

                if (calculator.Operation != "0")
                {

                    calculator.ReadValues();

                    calculator.Calculate();

                    calculator.ShowResult();

                }

            }
            catch (Exception ex)
            {

                Utility.WriteMessage($"Erro: {ex.Message}", "\n\n");

            }
            finally
            {
            
                Utility.TerminateConsole();

            }

        }

    }

}
