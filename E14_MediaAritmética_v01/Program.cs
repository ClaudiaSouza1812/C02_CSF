using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E14_MediaAritmética_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.WriteTitle("Receba do utilizador dois valores inteiros e devolva a média aritmética.", endTitle:"\n\n");

            double number01, number02, result;
            int tryInt;

            Utility.WriteMessage("Insira o primeiro número: ");

            while (!int.TryParse(Console.ReadLine(), out tryInt))
            {
                Utility.WriteMessage("Insira um número inteiro: ");
            }

            number01 = Convert.ToDouble(tryInt);

            Utility.WriteMessage("Insira o segundo número: ");

            while (!int.TryParse(Console.ReadLine(), out tryInt))
            {
                Utility.WriteMessage("Insira um número inteiro: ");
            }

            number02 = Convert.ToDouble(tryInt);

            result = (number01 + number02) / 2;

            Utility.WriteMessage($"Média aritmética: ({number01} + {number02}) / 2 = {result:F1}","\n");

            Utility.TerminateConsole();
        }
    }
}
