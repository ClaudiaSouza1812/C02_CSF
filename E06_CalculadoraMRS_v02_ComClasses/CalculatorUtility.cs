using D00_Utility;
using System;

namespace E06_Calculadora_v02_ComClasses
{

    internal class CalculatorUtility
    {

        internal static string ShowMenu()
        {

            string operation;
            bool founded;

            string[,] menu =
            {
                { "0", ". Exit" },
                { "1", ". Add" },
                { "2", ". Subtract" },
                { "3", ". Multiply" },
                { "4", ". Divide" }
            };

            do
            {

                Console.Clear();

                Utility.WriteTitle("Calculator", "", "\n\n");

                for (int r = 0; r < 5; r++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        Utility.WriteMessage($"{menu[r, c]}");
                    }

                    Utility.WriteMessage("\n");
                }

                Utility.WriteMessage("Choice > ", "\n");

                operation = Console.ReadLine();

                founded = false;

                // Otimizar: usando Find() --> LINQ
                for (int i = 0; i < menu.GetLength(0); i++)
                {
                    if (menu[i, 0] == operation)
                    {
                        founded = true;
                        break;
                    }
                }

            } while (!founded);

            return operation;

        }

    }

}
