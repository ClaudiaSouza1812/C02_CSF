// Fazer uma calculadora
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_AlgoritmoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            Utility.WriteTitle("Faça uma Calculadora");

            double value01, value02, result = 0;
            string choosedOperator;
            string[] operators = 
            {
                "Soma (+)", 
                "Subtração (-)", 
                "Multiplicação (*)", 
                "Divisão (/)"
            };

            Utility.WriteMessage("São suportados os seguintes operadores:", endMessage: "\n\n");

            foreach (string op in operators)
            {
                Utility.WriteMessage($"{op}", endMessage: "\n");
            }
            
            
            Utility.WriteMessage("Primeiro valor: ", "\n");
            value01 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Segundo valor: ");
            value02 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Operador desejado: ");
            choosedOperator = Console.ReadLine();

            switch (choosedOperator)
            {
                case "+":
                    result = value01 + value02;
                    break;
                case "-":
                    result = value01 - value02;
                    break;
                case "*":
                    result = value01 * value02;
                    break;
                case "/":
                    result = value01 / value02;
                    break;
                default:
                    Utility.WriteMessage("Entre dados válidos");
                    break;
            }

            Utility.WriteMessage($"Resultado: {value01} {choosedOperator} {value02} = {result}.", "\n", "\n\n");

            Utility.TerminateConsole();
        }
    }
}


/*
 using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_AlgoritmoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            Utility.WriteTitle("Faça uma Calculadora");

            int[] numbers = {};
            string[] operators = {};
            int result = 0;

            Utility.WriteMessage("Digite o numero seguido de um dos operadores á seguir:", endMessage:"\n\n");
            Utility.WriteMessage("Soma: \"+\"\nSubtração: \"-\"\nMultiplicação: \"*\"\nDivisão: \"/\"\nResultado: \"=\"\n", endMessage:"\n");
            Utility.WriteMessage("Quando terminar, digite '=' para exibir o resultado.", endMessage:"\n");

            
            do
            {
                Utility.WriteMessage("Valor: ");
                numbers.Append(Convert.ToInt16(Console.ReadLine()));
                Utility.WriteMessage("Operador: ");
                operators.Append(Console.ReadLine());
            } while (operators != "=");

            foreach (var oper in operators)
            {
                if (oper == "+")
                {
                    
                };
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                
            }



            Utility.CalculatorTemplate(numbers, operators, result);

            Utility.TerminateConsole();
        }
    }
}

 */
