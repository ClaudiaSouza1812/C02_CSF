using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v03_ComClasses
{
    internal class CalculatorUtility
    {
        // Método para checar e devolver um double
        internal static double CheckDouble(string input)
        {
            double reference;

            while (!double.TryParse(input, out reference))
            {
                Utility.WriteMessage($"Você digitou '{input}', entre um valor numérico ou decimal.", "", "\n");
                Utility.WriteMessage($"Valor: ");
                input = Console.ReadLine();
            }

            return reference;
        }

        //Método para checar e devolver um operador usando array

        internal static string ShowMenu()
        {
            Utility.WriteMessage("Insira um dos seguintes operadores: ", endMessage: "\n\n");

            string operation;
            bool status;

            string[,] opers = 
            {
                { "0", " Exit" },
                { "1", " Sum" },
                { "2", " Subtract" },
                { "3", " Multiply" },
                { "4", " Divide"}
            };

            do
            {
                
                Utility.WriteTitle("Calculator - set the new calculation data", "\n", "\n\n");

                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 2; col++)
                    {
                        Utility.WriteMessage($"{opers[row, col]}");
                    }
                    Utility.WriteMessage("\n");
                }

                Utility.WriteMessage("Operação: ");
                operation = Console.ReadLine();

                status = false;

                for (int i = 0; i < opers.GetLength(0); i++)
                {
                    if (opers[i, 0] == operation)
                    {
                        status = true;
                        break;
                    }
                }

            } while (!status);

            return operation;
        }
    }
}
