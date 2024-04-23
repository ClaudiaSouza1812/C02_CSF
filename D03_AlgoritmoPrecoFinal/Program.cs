/*
  Calcular preço final de um produto, mediante o preço inicial e a taxa de desconto.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_AlgoritmoPrecoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. declarar variáveis (numericas em double)

            double precoInicial, taxaDesconto, precoFinal;
            string nomeProduto;

            // 2. Pedir os valores

            Console.Write("Nome: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Preço inicial: ");
            precoInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de desconto: ");
            taxaDesconto = Convert.ToDouble(Console.ReadLine());

            // 5. Calcular preço final

            precoFinal = (precoInicial - (precoInicial * taxaDesconto) / 100);

            // 6. Mostrar resultado

            Console.WriteLine("O produto " + nomeProduto + " custa " + precoFinal.ToString() + ".");

            // 7. Pausar consola

            Console.ReadKey();
        }
    }
}
