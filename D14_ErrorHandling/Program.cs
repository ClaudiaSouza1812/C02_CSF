using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error handling", "", "\n\n");


            #region Sem tratamento de erros
            /*
            int number01;

            Utility.WriteMessage("Insira o número: ");
            number01 = Convert.ToInt16(Console.ReadLine());
            */
            #endregion

            #region Com tratamento de erros
            // use em teste, mas não em produção, jamais no produto final
            try
            {
                int number02;

                Utility.WriteMessage("Insira o número: ");
                number02 = Convert.ToInt16(Console.ReadLine());
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

            // event viewer do windows

            #endregion

            Utility.TerminateConsole();
        }
    }
}
