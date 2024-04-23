using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_AlgoritmoCodigoPaisIf
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

            if (countryDigit == "pt")
            {
                Console.WriteLine("A " + personName + " é de Portugal.");
            }
            else if (countryDigit == "es")
            {
                Console.WriteLine("A " + personName + " é de Espanha.");
            }
            else if (countryDigit == "fr")
            {
                Console.WriteLine("A " + personName + " é de França.");
            }
            else if (countryDigit == "br")
            {
                Console.WriteLine("A " + personName + " é do Brasil.");
            }
            else if (countryDigit == "it")
            {
                Console.WriteLine("A " + personName + " é de Itália.");
            }
            else
            {
                Console.WriteLine("A " + personName + " é de outro país.");
            }

            // stop the console

            Console.ReadKey();
        }
    }
}
