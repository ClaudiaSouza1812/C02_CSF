// Verificar se uma pessoa é maior de idade
// versão regular

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_AlgoritmoMaioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use Utility Class with SetUnicodeConsole() to set the encoding UTF8 format as the console output
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Verificar se uma pessoa é maior de idade");

            // Declare needed variables
            string personName;
            int personAge;
            
            // Ask and store user data
            Utility.WriteMessage("Digite um nome válido.", endMessage: "\n");
            Utility.WriteMessage("Nome: ");
            personName = Console.ReadLine();
            
            Utility.WriteMessage("Digite uma idade válida.", endMessage: "\n");
            Utility.WriteMessage("Idade: ");
            personAge = Convert.ToInt16(Console.ReadLine());

            // Do the age verification and print the result
            if (personAge >= 18)
            {
                Utility.WriteMessage($"{personName} é maior de idade.", "\n", "\n");
            }
            else
            {
                Utility.WriteMessage($"{personName} é menor de idade.", "\n", "\n");
            }

            // Stop the console
            Utility.TerminateConsole();
        }
    }
}


/*
 // Verificar se uma pessoa é maior de idade
// versão ótima

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_AlgoritmoMaioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use Utility Class with SetUnicodeConsole() to set the encoding UTF8 format as the console output
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Verificar se uma pessoa é maior de idade");

            // Declare needed variables
            string personName;
            string personAge;
            bool successChange;
            int age;


            // Ask and store user data
            do
            {
                Utility.WriteMessage("Digite um nome válido.", endMessage: "\n");
                Utility.WriteMessage("Nome: ");
                personName = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(personName) || personName.All(c => !char.IsLetter(c)));


            Utility.WriteMessage("Digite uma idade válida.", endMessage: "\n");
            Utility.WriteMessage("Idade: ");

            personAge = Console.ReadLine();
            successChange = int.TryParse(personAge, out age);

            while (successChange != true)
            {
                Utility.WriteMessage("Digite uma idade válida.", endMessage: "\n");
                Utility.WriteMessage("Idade: ");
                personAge = Console.ReadLine();
                successChange = int.TryParse(personAge, out age);
            };


            // Do the verification and print the result
            if (age >= 18)
            {
                Utility.WriteMessage($"{personName} é maior de idade.", "\n", "\n");
            }
            else
            {
                Utility.WriteMessage($"{personName} é menor de idade.", "\n", "\n");
            }

            // Stop the console
            Utility.TerminateConsole();
        }
    }
} 
*/
