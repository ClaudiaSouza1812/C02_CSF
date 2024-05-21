using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E26_AntecessorSucessor_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             19. Escreva um programa que apresente no ecrã antecessor e sucessor de um número introduzido pelo utilizador.
             */

            Utility.SetUnicodeConsole();

            int number;
            bool status01;

            do
            {
                Console.Clear();
                Utility.WriteTitle("apresente no ecrã antecessor e sucessor de um número", "", "\n\n");

                Utility.WriteMessage("Insert the number: ", "", "\n");
                status01 = int.TryParse(Console.ReadLine(), out number);

                if (status01)
                {
                    Utility.WriteMessage($"O valor antecessor de ({number}) é ({number-1}) e o valor sucessor é ({number+1}).", "\n", "\n");
                }
                else
                {
                    Utility.WriteMessage("Insira um número inteiro.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (!status01);


            Utility.TerminateConsole();

        }
    }
}
