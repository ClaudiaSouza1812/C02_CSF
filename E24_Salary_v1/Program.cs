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

            Dictionary<string, string> values = new Dictionary<string, string>()
            {
                {"salary", "0" },
                {"commission", "0" },
                {"percentage", "0" },
                {"sales", "0" },
            };

            
            int carsSold, percentageValue;
            double salesValue,commission, commissionValue, percentage, finalSalary, salary;
            bool status01, status02, status03;

            Utility.WriteMessage("Insira o salário funcionário: ");
            status01 = double.TryParse(Console.ReadLine(), out salary);

            Utility.WriteMessage("Insira a quantidade de carros vendidos: ");
            status02 = int.TryParse(Console.ReadLine(), out carsSold);




            commission =  carsSold * commissionValue;
            percentage = salesValue * percentageValue;

            finalSalary = salary + comm ission + percentage;

            foreach (string item in values.Keys)
            {
                Utility.WriteMessage($"Isert the {item}: ");
            }





            Utility.TerminateConsole();
        }
    }
}
