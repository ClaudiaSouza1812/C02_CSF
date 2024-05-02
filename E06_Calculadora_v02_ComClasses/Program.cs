using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            #region Variáveis

            #endregion

            #region Listar as operações

            #endregion

            #region Pedir valores e operação

            #endregion

            #region Realizar o cálculo

            #endregion

            #region Mostrar o resultado
            Calculator calc01 = new Calculator(2, 5, "/");

            Calculator calc02 = new Calculator();
            calc02.Value01 = 10;
            calc02.Value02 = 20;
            calc02.Operators = "*";

            Calculator calc03 = new Calculator();

            calc01.CalculatorWriteResult();
            Utility.PauseConsole();

            calc02.CalculatorWriteResult();
            Utility.PauseConsole();

            calc03.CalculatorReadData();


            Utility.TerminateConsole();
            #endregion
        }
    }
}
