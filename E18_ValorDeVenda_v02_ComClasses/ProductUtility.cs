using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E18_ValorDeVenda_v02_ComClasses
{
    internal class ProductUtility
    {
        internal static double CheckDouble(string input)
        {
            double value;

            while (!double.TryParse(input, out value))
            {
                Console.Clear();
                Utility.WriteTitle("Ler o valor base e o iva de um produto e calcular o valor final", "\n", "\n\n");
                Utility.WriteMessage("Insira um inteiro ou decimal: ");
                input = Console.ReadLine();
            }

            return value;
        }

        internal static string CheckString(string input) 
        { 
            string value;

            while (input )
            {
                
            }
        }
    }
}
