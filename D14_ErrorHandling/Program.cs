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

            Utility.WriteTitle("Error handling");


            #region Sem tratamento de erros

            int number;
            Utility.WriteMessage("Insira o número: ");
            number = Convert.ToInt16(Console.ReadLine());


            #endregion

            #region Com tratamento de erros



            #endregion

            Utility.TerminateConsole();
        }
    }
}
