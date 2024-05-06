using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v03_ComClasses
{
    internal class Calculator
    {
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        private double value01, value02, result;

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        
        internal string Operator { get; set; }

        #endregion

        #region Classic properties 1.0

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }

        internal double Value02
        {
            get { return value02; }
            set { value02 = value; }
        }
       
        #endregion

        #region Bodied-expression properties 3.0
        
        internal double Result
        {
            get => result;         // => lambda operator
            set => result = value;
        }
        
        #endregion
        #endregion

        #region Constructors (Public)
        // Fazer substituto do default constructor
        internal Calculator()
        {
            Value01 = 0;
            Value02 = 0;
            Result = 0;
            Operator = string.Empty;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios

        internal Calculator(double value01, double value02, double result, string operator01)
        {
            Value01 = value01;
            Value02 = value02;
            Result = result;
            Operator = operator01;
        }

        #endregion

        #region Methods (public or internal)

        // Método para devolver a soma de dois valores
        internal double Sum()
        {
            Result = Value01 + Value02;
            return Result;
        }

        // Método para devolver a subtração de dois valores
        internal double Sub()
        {
            Result = Value01 - Value02;
            return Result;
        }

        // Método para devolver a multiplicação de dois valores
        internal double Multi()
        {
            Result = Value01 * Value02;
            return Result;
        }

        // Método para devolver a divisão de dois valores
        internal double Div()
        {
            Result = Value01 / Value02;

            if (Value02 == 0)
            {
                Utility.WriteMessage($"Não existe divisão por {Value02}.", endMessage: "\n\n");
                return Result;
            }
            else
            {
                return Result;
            }
        }

        // Método para devolver o resultado de uma operação aritmética simples
        internal void Operations()
        {
            switch (Operator)
            {
                case "+":
                    Sum();
                    break;
                case "-":
                    Sub();
                    break;
                case "*":
                    Multi();
                    break;
                case "/":
                    Div();
                    break;
            }
        }


        #endregion

        #region Destructor

        #endregion
    }
}
