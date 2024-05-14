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
            // Escrever um programa que leia o valor base e o iva de um produto e que calcule o valor final do produto.

            Utility.SetUnicodeConsole();

            // 1. instanciar ArrayList

            ArrayList productList = new ArrayList();

            // 2. instancie 2 objetos do tipo Product
            // 3. Adicionar valores de tipos diferentes nas propriedades dos produtos instanciados (um a um)

            Product product01 = new Product();

            product01.Name = "lápis";
            product01.Price = 1.00;
            product01.Iva = 23;

            // Chame o método para calcular o preço de venda
            product01.CalculatePrice();

            // Instancie o segundo objeto e use o segundo construtor para inserir os dados como argumentos
            Product product02 = new Product("borracha", 0.50, 23);

            // Chame o método para calcular o preço de venda
            product02.CalculatePrice();

            // 2. invoque a classe ArrayList e adicione os objetos tipo Product instanciados
            productList.Add(product01);
            productList.Add(product02);

            // Mostre a lista de produtos armazenados
            Product.ListProduct(productList);

            // Instancie um terceiro objeto
            Product product03 = new Product();

            //  Peça os dados ao usuário
            product03.AskProduct();

            // Chame o método para calcular o preço de venda
            product03.CalculatePrice();

            // Adicione os objetos tipo Product instanciados na ArrayList
            productList.Add(product03);

            // Mostre a lista de produtos armazenados
            Product.ListProduct(productList);

            

            Utility.TerminateConsole();
        }
    }
}
