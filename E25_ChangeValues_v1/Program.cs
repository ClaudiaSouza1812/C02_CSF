using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E25_ChangeValues_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             18. Escrever um programa que troque entre si o valor contido em duas variáveis inteiras a e b, ou seja, o valor contido em a passa a ser o valor de b e vice-versa, sem utilizar uma terceira variável.
             */

            Utility.SetUnicodeConsole();

            bool status01, status02;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Trocar entre si o valor contido em duas variáveis inteiras (a) e (b)", "", "\n\n");

                Utility.WriteMessage("Insert the value of (a): ", "", "\n");
                status01 = int.TryParse(Console.ReadLine(), out int a);

                Utility.WriteMessage("Insert the value of (b): ", "", "\n");
                status02 = int.TryParse(Console.ReadLine(), out int b);

                if (status01 & status02)
                {
                    Utility.WriteMessage($"O valor de (a) agora é: {b}", "\n", "\n");
                    Utility.WriteMessage($"O valor de (b) agora é: {a}", "", "\n");
                }
                else
                {
                    Utility.WriteMessage("Insira números inteiros.", "", "\n");
                    Utility.PauseConsole();
                }

            } while (!status01 || !status02);
            

            Utility.TerminateConsole();
        }
    }
}
