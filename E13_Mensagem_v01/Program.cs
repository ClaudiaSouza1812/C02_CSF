using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E13_Mensagem_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.WriteTitle("Apresente o nome e apelido inserido pelo usuário junto com uma mensagem", "", "\n\n");

            string name, surname;
            bool status = true;
            int number;

            do
            {
                Utility.WriteMessage("Insira seu nome: ");
                name = Console.ReadLine();
                status = int.TryParse(name, out number);
            } while (status) ;

            
            status = true;

            do
            {
                Utility.WriteMessage("Insira seu sobrenome: ");
                surname = Console.ReadLine();
                status = int.TryParse(surname, out number);
            } while (status);

            

            Utility.WriteMessage($"{name} {surname} acabou de ganhar o 1º prémio. Parabéns!", "\n", "\n");

            Utility.TerminateConsole();
        }
    }
}
