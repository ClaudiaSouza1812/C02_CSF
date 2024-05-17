using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E20_ConversorDeTempo_v01_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escrever um programa que converta um valor para horas, minutos e segundos.
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Converta um valor para horas, minutos e segundos.", "", "\n\n");

            int value;
            int hours, finalHour, finalMinutes, finalSeconds;

            Utility.WriteMessage("Insira o valor em minutos: ");
            value = Convert.ToInt16(Console.ReadLine());

            hours = 60;

            finalHour = value / hours;
            finalMinutes = value - (finalHour * hours);
            finalSeconds = finalMinutes - (value - (finalHour * hours));

            Utility.WriteMessage($"{finalHour:D2}:{finalMinutes:D2}:{finalSeconds:D2}");

            Utility.TerminateConsole();
        }
    }
}
