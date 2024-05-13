using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E17_ValorDeVenda_v01_ComClasses
{
    internal class Price
    {
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */
        internal double Value { get; set; }
        internal int Iva { get; set; }
        internal double Result { get; set; }
        #endregion

        #region Classic properties 1.0
        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        #endregion

        #region Bodied-expression properties 3.0
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */

        #endregion
        #endregion

        #region Constructors (Public)
        // Fazer substituto do default constructor
        internal Price()
        {
            Value = 0;
            Iva = 23;
            Result = 0;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios
        internal Price(double value)
        {
            Value = value;
        }

        #endregion

        #region Methods (public or internal)

        internal void CalculatePrice()
        {
            Iva = 23;
            Result = Value + (Value * Iva);
        }

        // Método para requisitar ao usuário a inserção do preço, via console, para adição da taxa de IVA a 23%.
        internal void AskPrice()
        {
            Utility.WriteTitle("Calcule o seu preço de venda acrescido da taxa de IVA a 23%.", "\n", "\n\n");

            Utility.WriteMessage("Insira o preço base: ");
            Value = PriceUtility.CheckDouble(Console.ReadLine());
        }

        internal void ShowPrice()
        {
            Utility.WriteTitle("Price - Result", "\n", "\n\n");

            CalculatePrice();

            Utility.WriteMessage($"O preço de venda é: {Result}", "", "\n");
            
        }
        #endregion

        #region Destructor

        #endregion
    }
}
