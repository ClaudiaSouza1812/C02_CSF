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
            double hours, minutes, seconds;

            Utility.WriteMessage("Insira o valor; ");
            value = Convert.ToInt16(Console.ReadLine());

            hours = value / 60;
            minutes = value / 360;
            seconds = value / 3600;

            Utility.TerminateConsole();
        }
    }
}
