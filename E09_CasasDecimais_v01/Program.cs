using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E09_CasasDecimais_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            double value01 = 8.456796, value02 = 9.8, value03 = 3.12345, value04 = 6;

            Utility.WriteTitle("Escreva um programa que apresente números arredondados em três linhas diferentes", endTitle: "\n\n");

            Utility.WriteMessage("Todos arredondados a três casas decimais: ", "", "\n");
            Utility.WriteMessage($"{value01:F3}\n{value02:F3}\n{value03:F3}\n{value04:F3}", endMessage:"\n\n");

            Utility.WriteMessage("Todos arredondados a uma casa decimal: ", "", "\n");
            Utility.WriteMessage($"{value01:F1}\n{value02:F1}\n{value03:F1}\n{value04:F1}", endMessage: "\n\n");

            Utility.WriteMessage("Todos sem casa decimal: ", "", "\n");
            Utility.WriteMessage($"{value01:F0}\n{value02:F0}\n{value03:F0}\n{value04:F0}", endMessage: "\n\n");

            Utility.TerminateConsole();
        }
    }
}
