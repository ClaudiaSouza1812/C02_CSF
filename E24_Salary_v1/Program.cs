using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E24_Salary_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            17. Num determinado stand de automóveis, os vendedores ganham um salário mensal base X, uma comissão de Y euros por cada automóvel que vendem e uma percentagem P sobre o valor das vendas V que efetuarem. Escreva um programa que calcule e imprima o salário que um vendedor vai auferir este mês.
            */

            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Final Salary", "", "\n\n");

            int numberCarsSold;
            double commiPerSale = 50, percent = 0.5, salesValue, commission, percentage, salary, finalSalary;
            bool status01, status02, status03;

            Utility.WriteMessage("Insira o salário funcionário: ");
            status01 = double.TryParse(Console.ReadLine(), out salary);

            Utility.WriteMessage("Insira a quantidade de carros vendidos: ");
            status02 = int.TryParse(Console.ReadLine(), out numberCarsSold);

            Utility.WriteMessage("Insira a soma do valor dos carros vendidos: ");
            status03 = double.TryParse(Console.ReadLine(), out salesValue);

            if (status01 & status02 & status03)
            {
                commission = numberCarsSold * commiPerSale;
                percentage = salesValue * percent / 100;
                finalSalary = salary + commission + percentage;

                Utility.WriteMessage($"Commission: {commission:F2}.", "", "\n");
                Utility.WriteMessage($"Percentage: {percentage:F2}.", "", "\n");
                Utility.WriteMessage($"Salário final: {finalSalary:F2}.", "", "\n");
            }
            else
            {
                Utility.WriteMessage("Insira valores válidos.");
            }

            
            Utility.TerminateConsole();
        }
    }
}
