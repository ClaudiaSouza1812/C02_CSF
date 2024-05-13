using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E17_ValorDeVenda_v01_ComClasses
{
    internal class PriceUtility
    {
        // Método para checar e devolver um double
        internal static double CheckDouble(string input)
        {
            double value;

            while (!double.TryParse(input, out value))
            {
                Console.Clear();
                Utility.WriteTitle("Calcule o seu preço de venda acrescido da taxa de IVA a 23%.", "", "\n\n");
                Utility.WriteMessage($"Você digitou '{input}', entre um valor numérico ou decimal.", "", "\n");
                Utility.WriteMessage("Insira o preço base: ");
                input = Console.ReadLine();
            }

            return value;
        }
    }
}
