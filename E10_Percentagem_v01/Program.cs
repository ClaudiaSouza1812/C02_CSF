using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E10_Percentagem_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Escreva um programa que apresente os números (8.456796, 9.8, 3.12345, 6) em percentagem", endTitle: "\n\n");

            double[] values = {8.456796, 9.8, 3.12345, 6};
            double result;

            foreach (double item in values)
            {   
                result = item * 100;
                Utility.WriteMessage($"{result}%", endMessage: "\n");
            }

            Utility.TerminateConsole();
        }
    }
}
