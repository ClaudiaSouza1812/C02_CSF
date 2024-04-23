// Ler o nome de 5 formandos da turma e listar no final
// versão regular
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_AlgoritmoTurma5Formando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use Utility Class for unicode output and to show the title
            Utility.SetUnicodeConsole();
            Utility.WriteTitle("Ler o nome de 5 formandos da turma e listar no final");

            // Declare needed variables
            string[] formandos = new string[5];
            
            // Request data to user
            Utility.WriteMessage("Por favor, insira o nome de 5 formandos.", endMessage: "\n");

            for (int i = 0; i < formandos.Length; i++)
            {
                Utility.WriteMessage($"Formando {i}: ");
                formandos[i] = Console.ReadLine();
            };

            // Show the list of trainees
            Utility.WriteMessage("Os formandos inseridos foram: ", "\n", "\n\n");

            for (int j = 0; j < formandos.Length; j++)
            {
                Utility.WriteMessage($"{formandos[j]}", endMessage: "\n");
            }

            Utility.TerminateConsole();
        }
    }
}


/*
 // Ler o nome de 5 formandos da turma e listar no final
// versão regular
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_AlgoritmoTurma5Formando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] formandos = new string[5];
            int i = -1;
            int j;

            Console.WriteLine("Por favor, insira o nome de 5 formandos.");

            while (i < formandos.Length - 1)
            {
                i++;
                Console.Write($"Formando {i}: ");
                formandos[i] = Console.ReadLine();
            };

            Console.WriteLine("Os formandos inseridos foram: ");

            for (j = 0; j < formandos.Length; j++)
            {
                Console.WriteLine($"{formandos[j]}");
            }

            Console.WriteLine("Aperte qualquer tecla para encerrar o programa, até a próxima.");
            Console.ReadKey();
        }
    }
}

*/