using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E23_AverageSpend_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16. Escrever um programa que calcule a despesa média diária que um turista despendeu numa viagem de quatro dias ao Porto, sabendo que cada dia gastou mais 20 % do que no dia anterior.O valor da despesa deverá ser apresentado sem casas decimais.

            Utility.SetUnicodeConsole();

            int firstDaySpend, totalSpend, averageSpend;

            

            Utility.WriteMessage($"A despesa média diária foi de: {firstDaySpend}");

            Utility.TerminateConsole();
        }
    }
}
