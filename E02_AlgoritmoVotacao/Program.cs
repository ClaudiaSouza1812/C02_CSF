// Verificar se uma pessoa pode votar
// versão regular

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E02_AlgoritmoVotacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare needed variables
            string personName;
            int personAge;
            int voteAge = 18;

            // Print title
            Utility.WriteTitle("Verificar se uma pessoa pode votar");

            // Request user data
            Utility.WriteMessage("Seu nome: ");
            personName = Console.ReadLine();

            Utility.WriteMessage("Sua idade: ");
            personAge = Convert.ToInt16(Console.ReadLine());

            // Do the verification and print the result
            if (personAge >= voteAge)
            {
                Utility.WriteMessage($"{personName} tem {personAge} anos e pode votar.", "\n\n", "\n\n");
            }
            else 
            {
                Utility.WriteMessage($"{personName} tem {personAge} anos e não pode votar.", "\n\n", "\n\n");
            };
           
            Utility.TerminateConsole();
        }
    }
}


/*
 // Verificar se uma pessoa pode votar
// versão boa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E02_AlgoritmoVotacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare needed variables
            string personName;
            int personAge;
            int voteAge = 18;

            // Print title
            Utility.WriteTitle("Verificar se uma pessoa pode votar");

            // Request user data
            Utility.WriteMessage("Seu nome: ", endMessage: "\n");
            personName = Console.ReadLine();

            Utility.WriteMessage("Sua idade: ", endMessage: "\n");
            personAge = Convert.ToInt16(Console.ReadLine());

            // Do the verification and print the result
            switch (personAge)
            {
                case int age when age >= voteAge:
                    Utility.WriteMessage($"{personName} tem {personAge} anos e pode votar.");
                    break;
                case int age when age < voteAge:
                    Utility.WriteMessage($"{personName} tem {personAge} anos e não pode votar.");
                    break;
            }

            Utility.TerminateConsole();
        }
    }
}
 */