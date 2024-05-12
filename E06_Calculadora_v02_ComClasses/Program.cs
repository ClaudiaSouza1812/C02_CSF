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

            Calculator calc01 = new Calculator(2, 0, "/");

            Calculator calc02 = new Calculator();
            calc02.Value01 = 10;
            calc02.Value02 = 20;
            calc02.Operators = "*";

            Calculator calc03 = new Calculator();

            try
            {
                calc01.CalculatorWriteResult();
                calc02.CalculatorWriteResult();
                calc03.CalculatorReadData();
            }
            catch (DivideByZeroException ex)
            {
                Utility.WriteMessage("Não podes dividir por zero.", "\n", "\n");
            }
            catch (FormatException ex)
            {
                Utility.WriteMessage("Escreve um número.", "\n", "\n");
            }
            catch (Exception ex)    // ex: Exception variable
            {
                // versão de desenvolvimento, mostra o erro no ecrã
                Utility.WriteMessage($"Erro: {ex.Message}", "\n", "\n");

                // versão de produção (devemos implementar um sistema de logs
                //Utility.WriteMessage("Aconteceu um erro.", "\n", "\n\n");   

                // lançar o erro, interrompe a execução - versão de desenvolvimento
                //throw;  
            }
            finally // é sempre executado, havendo erro ou não
            {
                Utility.WriteMessage("Até a próxima!", "\n", "\n");
            }

            /*
            Calculator calc01 = new Calculator(2, 0, "/");

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
            */

            Utility.TerminateConsole();
            
            #endregion
        }
    }
}
