using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E12_ParteInteira_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.WriteTitle("Apresente no ecrã a parte inteira de um número introduzido pelo utilizador", "", "\n\n");

            double dec;
            int integer;
            bool status = false;

            do
            {
                Utility.WriteMessage("Insira o número decimal: ");
                status = double.TryParse(Console.ReadLine(), out dec);

            } while (status != true);

            integer = Convert.ToInt16(dec);

            Utility.WriteMessage($"O número decimal {dec} tem o numero {integer} como inteiro ", "\n", "\n");

            Utility.TerminateConsole();
        }
    }
}
