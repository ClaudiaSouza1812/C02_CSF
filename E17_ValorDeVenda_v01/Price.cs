using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E17_ValorDeVenda_v01
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
        double Value { get; set; }
        int Iva { get; set; }
        double Result { get; set; }
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
        public Price()
        {
            Value = 0;
            Iva = 0;
            Result = 0;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios
        public Price(double value, int iva)
        {
            Value = value;
            Iva = iva;
        }

        #endregion

        #region Methods (public or internal)

        internal void CalculatePrice()
        {

        }

        // Método para requisitar ao usuário a inserção do preço, via console, para adição da taxa de IVA a 23%.
        internal void AskPrice()
        {
            Utility.WriteTitle("Calcule o seu preço de venda acrescido da taxa de IVA a 23%.", "", "\n\n");

            Utility.WriteMessage("Insira o preço base: ");
            Value = PriceUtility.CheckDouble(Console.ReadLine());
        }

        internal void ShowPrice()
        {

        }
        #endregion

        #region Destructor

        #endregion
    }
}
