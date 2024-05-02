using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15_CambioDolarEuro_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.WriteTitle("Converta dólares americanos para euros", endTitle:"\n\n");
            //  (a taxa de câmbio é de 1,1579 USD para 1€).

            double euroValue = 0.93, dolarValue;

            Utility.WriteMessage("Digite a quantia em Dólar que deseja cambiar para Euro: ");

            while (!double.TryParse(Console.ReadLine(), out dolarValue))
            {
                Utility.WriteMessage("Digite caracteres numéricos: ");
                dolarValue = Convert.ToDouble(dolarValue);
            }

            double result = euroValue * dolarValue;
            Utility.WriteMessage($"{dolarValue} dólar(es) americano(s) equivale(m) a {result:F2} euro(s).", "\n");

            Utility.TerminateConsole();
        }
    }
}
