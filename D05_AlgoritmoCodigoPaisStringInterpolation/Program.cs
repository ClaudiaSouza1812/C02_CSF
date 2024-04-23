using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_AlgoritmoCodigoPaisStringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create needed variables

            string personName, countryDigit;

            // Take the inputs

            Console.Write("Seu nome: ");
            personName = Console.ReadLine();

            Console.Write("Código país: ");
            countryDigit = Console.ReadLine().ToLower();

            // return the results

            switch (countryDigit)
            {
                case "pt":
                    Console.WriteLine($"A {personName} é de Portugal.");
                    break;
                case "es":
                    Console.WriteLine($"A {personName} é de Espanha.");
                    break;
                case "fr":
                    Console.WriteLine($"A {personName} é de França.");
                    break;
                case "br":
                    Console.WriteLine($"A {personName} é de Brasil.");
                    break;
                case "it":
                    Console.WriteLine($"A {personName} é de Itália.");
                    break;
                default:
                    Console.WriteLine($"A {personName} é de outro país.");
                    break;
            }

            // Stop the console

            Console.ReadKey();
        }
    }
}
