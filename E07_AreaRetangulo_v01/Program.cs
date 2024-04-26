using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E07_AreaRetangulo_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Apresentar a área de um retângulo a partir de dois valores (altura e largura).", endTitle: "\n\n");

            double altura, largura, area;

            Utility.WriteMessage("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            area = altura * largura;

            Utility.WriteMessage($"A área é: {area}.", "\n", "\n");

            Utility.TerminateConsole();
        }
    }
}
