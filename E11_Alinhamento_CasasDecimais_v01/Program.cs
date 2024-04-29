using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E11_Alinhamento_CasasDecimais_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Escrever um programa que leia do utilizador 3 números e apresente dois resultados diferentes", endTitle: "\n\n");

            double[] numbers = new double[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Utility.WriteMessage($"Insira o {i + 1}º número: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            };

            Utility.WriteMessage("Números alinhados à esquerda com duas casas decimais e cada um com 20 casas:", "\n", "\n");

            foreach (double item in numbers)
            {
                Utility.WriteMessage($"{item,-20:F2}");
            }


            Utility.WriteMessage("Números alinhados à direita, com uma casa decimal e cada um com 20 casas:", "\n\n", "\n");
            
            foreach (double item in numbers)
            {
                Utility.WriteMessage($"{item,20:F1}");
            }

            Utility.TerminateConsole();
        }
    }
}
