using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E18_ValorDeVenda_v02_ComClasses
{
    internal class Product
    {
        #region Fields (properties, private variables)

        #endregion

        #region Properties (public or internal)
        #region Classic properties 1.0

        #endregion
        #region Auto-implemented properties 2.0
        // Properties with internal use only
        internal string Name { get; set; }
        internal double Price { get; set; }
        internal double Iva { get; set; }
        internal double Result { get; set; }
        #endregion
        #region Bodied-expression properties 3.0

        #endregion

        #endregion

        #region Constructors (public or internal)

        internal Product()
        {
            Name = string.Empty;
            Price = 0;
            Iva = 0;
            Result = 0;
        }

        internal Product(string name, double price, double iva)
        {
            Name = name;
            Price = price;
            Iva = iva;
        }

        #endregion

        #region Methods (public or internal)

        // it can only be called by the classes within the same project and by the  
        internal void CalculatePrice()
        {
            Result = Price + (Price * Iva / 100);
        }

        // it can only be called by the classes within the same project
        // it cant be called by the object instance, only by its own class, like: Product.ListProduct(list)
        internal static void ListProduct(ArrayList productList)
        {
            Utility.WriteTitle("Ler o valor base e o iva de um produto e calcular o valor final", "\n", "\n\n");

            foreach (Product item in productList)
            {
                Utility.WriteTitle("Product final price - Result", "\n", "\n\n");

                Utility.WriteMessage($"Produto: {item.Name}\nValor base: {item.Price:F2}€\nIVA: {item.Iva}%\nPreço final: {item.Result:F2}€", "", "\n");
            }

        }

        internal void AskProduct()
        {
            Utility.WriteTitle("Inserir o nome, valor base e o iva de um produto e calcular o valor final", "\n", "\n\n");

            Utility.WriteMessage("Insira o nome do produto: ", "", "\n");
            Name = ProductUtility.CheckString(Console.ReadLine());

            Utility.WriteMessage("Insira preço base do produto: ", "", "\n");
            Price = ProductUtility.CheckDouble(Console.ReadLine());

            Utility.WriteMessage("Insira o IVA: ", "", "\n");
            Iva = ProductUtility.CheckDouble(Console.ReadLine());
        }

        #endregion

        #region Destructor

        #endregion
    }
}
