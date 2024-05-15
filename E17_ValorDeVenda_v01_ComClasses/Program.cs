using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E17_ValorDeVenda_v01_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escrever um programa que leia o preço base de um determinado produto e calcule o seu valor de venda ao público(ou seja, valor acrescido da taxa de IVA a 23 %).

            Utility.SetUnicodeConsole();
            
            Price price01 = new Price();

            price01.Value = 10;
            price01.ShowPrice();

            Price price02 = new Price();
            
            price02.AskPrice();
            price02.ShowPrice();
            
            Price price03 = new Price(15);

            price03.ShowPrice();
            
            Utility.TerminateConsole();
        }
    }
}
