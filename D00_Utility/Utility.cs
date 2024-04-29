﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public class Utility
    {
        public static void SetUnicodeConsole()
        {
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
        }

        public static void WriteTitle(string title, string beginTitle = "", string endTitle = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{beginTitle}{new string('-', title.Length)}\n{title.ToUpper()}\n{new string('-', title.Length)}{endTitle}");
            Console.ForegroundColor = ConsoleColor.White;   // Reset original color
        }

        /*
        public static void WriteMessage(string message, int beginMessage = 0, int endMessage = 0)
        {
            // Console.WriteLine($"\nBoolean - inscrito: {inscrito}\n");

            string skipLine01 = string.Empty;
            string skipLine02 = "";

            for (int i = 0; i < beginMessage; i++)
            {
                skipLine01 = skipLine01 + "\n";
            };

            for (int i = 0; i < endMessage; i++)
            {
                skipLine02 = skipLine02 + "\n";
            };

            Console.Write($"{skipLine01}{message}{skipLine02}");
        }

        ex:
        Utility.WriteMessage($"String - nome completo: {nomeCompleto}", 0, 1);
        Utility.WriteMessage($"String - horário: {horario}", 0, 2);

        */

        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {
           
            Console.Write($"{beginMessage}{message}{endMessage}");
        }
        public static void TerminateConsole()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPrime qualquer tecla para terminares.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }

        public static void CalculatorTemplate(int[] numbers, string[] operators, int result = 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('-', 18));
            Console.WriteLine($"| {numbers[0]} {operators[0]} {result}          |");
            Console.WriteLine(new string('-', 18));
            Console.WriteLine($"| AC (+/-)  %  {operators[3]} |");
            Console.WriteLine($"| {numbers[7]}    {numbers[8]}    {numbers[9]}  {operators[2]} |");
            Console.WriteLine($"| {numbers[4]}    {numbers[5]}    {numbers[6]}  {operators[1]} |");
            Console.WriteLine($"| {numbers[1]}    {numbers[2]}    {numbers[3]}  {operators[0]} |");
            Console.WriteLine($"| {numbers[0]}         ,  {operators[4]} |");
            Console.WriteLine(new string('-', 18));
            Console.ResetColor();

            foreach (int item in numbers)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ResetColor();
            }

        }
    }
}
