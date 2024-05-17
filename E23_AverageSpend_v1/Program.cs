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

            Utility.WriteTitle("Despesa média diária de uma viagem de quatro dias", "", "\n\n");

            int DaySpend, averageSpend, totalSpend = 0;
            bool status;
            
            Utility.WriteMessage($"Insira a despesa do primeiro dia: ");

            status = int.TryParse(Console.ReadLine(), out DaySpend);

            if (status)
            {
                for (int i = 0; i < 4; i++)
                {
                    Utility.WriteMessage($"{i + 1}º dia: {DaySpend}", "", "\n");
                    totalSpend = totalSpend + DaySpend;
                    DaySpend = DaySpend + (DaySpend * 20 / 100);
                    
                     
                }
                averageSpend = totalSpend / 4;
                Utility.WriteMessage($"A despesa média diária foi de {averageSpend}");
            }

            Utility.TerminateConsole();
        }
    }
}
