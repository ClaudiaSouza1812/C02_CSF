using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_AlgoritmoMedia
{
    // D01_VisualStudio.Program --> Namespace.Class
    // D02_AlgoritmoMedia.Program 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ---------------------
                declarar as variáveis
                ---------------------

                Camel Case --> camelCase

                1. declarar e atribuir simultaneamente
                string nome = "mrs";

                
                2. primeiro declara, depois atribuir
                string nome;
                nome = "mrs"

            */

            // 1. declarar as variáveis

            string valor01;
            int valor02;
            double resultado;

            // 2. pedir primeiro valor

            Console.Write("Número 1: ");
            valor01 = Console.ReadLine();   // vou ter que converter no cálculo

            // 3. pedir segundo valor

            Console.Write("Número 2: ");
            valor02 = Convert.ToInt16(Console.ReadLine());  // vou ter que converter ao ler

            // 4. calcular a média

            resultado = (Convert.ToDouble(valor01) + Convert.ToDouble(valor02)) / 2;

            // 5. mostrar o resultado

            Console.WriteLine("Média: " + resultado.ToString());    // melhorar a concatenação

            // 6. pausar consola

            Console.ReadKey();
        }
    }
}
