using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E18_ValorDeVenda_v02_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escrever um programa leia o valor base e o iva de um produto e que calcule o valor final do produto.

            Utility.SetUnicodeConsole();

            // 1. instanciar array list
            
            ArrayList productList = new ArrayList();

            // instancie 2 objetos do tipo Product
            // 3.  Adicionar valores de tipos diferentes (um a um)
            Product product01 = new Product();

            product01.Name = "lápis";
            product01.Price = 1.00;
            product01.Iva = 23;

            product01.CalculatePrice();

            // use segundo construtor com valores nos argumentos 
            Product product02 = new Product("borracha", 0.50, 23);

            product02.CalculatePrice();

            // 2. invoque a classe array list e adicione os objetos tipo Product instanciados

            productList.Add(product01);
            productList.Add(product02);

            Product.ListProduct(productList);

            Product product03 = new Product();
            product03.AskProduct();
            

            Utility.TerminateConsole();
        }
    }
}
