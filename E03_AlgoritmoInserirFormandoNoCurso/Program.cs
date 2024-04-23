// Inscrever um formando num curso
// versão regular
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_AlgoritmoInserirFormandoNoCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use class utility to set up unicode and show the title
            Utility.SetUnicodeConsole();
            Utility.WriteTitle("Inscrever um formando num curso");

            // Declare needed variables
            string traineeName; 
            string[] courses = {"Restart - Developer", "Data Science", "Web Development", "Game Development"};
            int choosedCourse;

            // Request data to user
            Utility.WriteMessage("Nome do Formando: ");
            traineeName = Console.ReadLine();

            // Show available courses 
            Utility.WriteMessage($"\nBem vindo(a) {traineeName}, esses são os cursos disponíveis: \n");

            for (int i = 0; i < courses.Length; i++) 
            {
                Utility.WriteMessage($"{i}: {courses[i]}\n");
            };

            // Request data to user
            Utility.WriteMessage("\nDigite o número do curso em que deseja se inscrever: ");
            choosedCourse = Convert.ToInt16(Console.ReadLine());

            // Check the course number and show the corresponding message
            while (choosedCourse < 0 || choosedCourse > courses.Length - 1)
            {
                Utility.WriteMessage($"\nVocê digitou {choosedCourse}, insira um número válido.");
                Utility.WriteMessage("\nDigite o número do curso em que deseja se inscrever: ");
                choosedCourse = Convert.ToInt16(Console.ReadLine());
            }

            Utility.WriteMessage($"Você digitou {choosedCourse} e foi inscrito com sucesso no curso: {courses[choosedCourse]}.", "\n", "\n");
            
            Utility.TerminateConsole();

        }
    }
}

/*
 // Inscrever um formando num curso

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_AlgoritmoInserirFormandoNoCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            string traineeName; 
            string[] courses = {"Restart - Developer", "Data Science", "Web Development", "Game Development"};
            int i = -1, choosedCourse = -1;

            Console.Write("Nome do Formando: ");
            traineeName = Console.ReadLine();

            Console.WriteLine($"\nBem vindo(a) {traineeName}, esses são os cursos disponíveis: \n");

            while (i < courses.Length - 1) 
            {
                i++;
                Console.WriteLine($"{i}: {courses[i]}");
            };

            Console.Write("\nDigite o número do curso em que deseja se inscrever: ");
            choosedCourse = Convert.ToInt16(Console.ReadLine());

            while (choosedCourse < 0 || choosedCourse > courses.Length - 1)
            {
                Console.WriteLine($"\nVocê digitou {choosedCourse}, insira um número válido.");
                Console.Write("\nDigite o número do curso em que deseja se inscrever: \n");
                choosedCourse = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine($"\nVocê digitou {choosedCourse} e foi inscrito com sucesso no curso: {courses[choosedCourse]}. \nAperte qualquer botão para encerrar a aplicação, até a próxima.");
            
            Console.ReadKey();

        }
    }
}
 */
