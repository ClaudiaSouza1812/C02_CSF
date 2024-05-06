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

        internal Calculator(double value01, double value02,string operator01)
        {
            Value01 = value01;
            Value02 = value02;
            Operator = operator01;
        }

        #endregion

        #region Methods (public or internal)

        // Método para devolver a soma de dois valores
        internal void Sum()
        {
            Result = Value01 + Value02;
        }

        // Método para devolver a subtração de dois valores
        internal void Sub()
        {
            Result = Value01 - Value02;
        }

        // Método para devolver a multiplicação de dois valores
        internal void Multi()
        {
            Result = Value01 * Value02;
        }

        // Método para devolver a divisão de dois valores
        internal void Div()
        {
            Result = Value01 / Value02;

            if (Value02 == 0)
            {
                Utility.WriteMessage($"Não existe divisão por {Value02}.", endMessage: "\n\n");
            }
        }

        // Método para devolver o resultado de uma operação aritmética simples
        internal void Calculate()
        {
            switch (Operator)
            {
                case "1":
                    Sum();
                    break;
                case "2":
                    Sub();
                    break;
                case "3":
                    Multi();
                    break;
                case "4":
                    Div();
                    break;
                
            }
        }

        internal void ShowOperation()
        {
            switch (Operator)
            {
                case "1":
                    Utility.WriteTitle("Addition Operation (+)", "\n", "\n\n");
                    Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (+)\nSegundo valor: {Value02}", endMessage: "\n");
                    break;
                case "2":
                    Utility.WriteTitle("Subtraction Operation (-)", "\n", "\n\n");
                    Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (-)\nSegundo valor: {Value02}", endMessage: "\n");
                    break;
                case "3":
                    Utility.WriteTitle("Multiplication Operation (*)", "\n", "\n\n");
                    Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (*)\nSegundo valor: {Value02}", endMessage: "\n");
                    break;
                case "4":
                    Utility.WriteTitle("Division Operation (/)", "\n", "\n\n");
                    Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (/)\nSegundo valor: {Value02}", endMessage: "\n");
                    break;
                default:
                    Utility.WriteTitle("Erro", "", "\n\n");
                    Utility.WriteMessage("Insira dados válidos (Número da operação escolhida, 2 valores).", "", "\n");
                    break;
            }
        }

        // Método para mostrar no console o resultado de uma operação aritmética simples
        internal void ShowResult()
        {
            ShowOperation();

            Utility.WriteTitle("Calculator - result", "\n", "\n\n");

            Utility.WriteMessage($"Resultado: {Result}", endMessage: "\n");
        }

        // Método para requisitar ao usuário a inserção dos dados, via console, para uma operação aritmética simples
        internal void AskData()
        {
            Utility.WriteMessage($"Primeiro valor: ");
            Value01 = CalculatorUtility.CheckDouble(Console.ReadLine());

            Utility.WriteMessage($"Segundo valor: ");
            Value02 = CalculatorUtility.CheckDouble(Console.ReadLine());
        }

        #endregion

        #region Destructor

        #endregion
    }
}
