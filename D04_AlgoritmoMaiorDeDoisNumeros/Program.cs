/*
    Decidir qual de dois números é o maior, ou se são iguais
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_AlgoritmoMaiorDeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Declarar variaveis

            int numero01, numero02;

            // 2. Pedir valores

            Console.Write("Primeiro numero: ");
            numero01 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Segundo número: ");
            numero02 = Convert.ToInt16(Console.ReadLine());

            if (numero01 > numero02) 
            {
                Console.WriteLine("O primeiro numero " + numero01 + " é maior.");
            }
            else if (numero02 > numero01)
            {
                Console.WriteLine("O segundo número " + numero02 + " é maior.");
            }
            else
            {
                Console.WriteLine("Os numeros são iguais.");
            }

            // 3. Pausar consola

            Console.ReadKey();
        }
    }
}
