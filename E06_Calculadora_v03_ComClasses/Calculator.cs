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
                    Console.Clear();
                    Utility.WriteTitle("Addition Operation (+)", "\n", "\n\n");
                    
                    if (Value01 != 0)
                    {
                        Console.Clear();
                        Utility.WriteTitle("Addition Operation (+)", "\n", "\n\n");
                        Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (+)\nSegundo valor: {Value02}", endMessage: "\n");
                    }
                    break;
                case "2":
                    Console.Clear();
                    Utility.WriteTitle("Subtraction Operation (-)", "\n", "\n\n");
                    if (Value01 != 0)
                    {
                        Console.Clear();
                        Utility.WriteTitle("Subtraction Operation (-)", "\n", "\n\n");
                        Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (-)\nSegundo valor: {Value02}", endMessage: "\n");
                    }
                    break;
                case "3":
                    Console.Clear();
                    Utility.WriteTitle("Multiplication Operation (*)", "\n", "\n\n");
                    if (Value01 != 0)
                    {
                        Console.Clear();
                        Utility.WriteTitle("Multiplication Operation (*)", "\n", "\n\n");
                        Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (*)\nSegundo valor: {Value02}", endMessage: "\n");
                    }
                    break;
                case "4":
                    Console.Clear();
                    Utility.WriteTitle("Division Operation (/)", "\n", "\n\n");
                    if (Value01 != 0)
                    {
                        Console.Clear();
                        Utility.WriteTitle("Division Operation (/)", "\n", "\n\n");
                        Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (/)\nSegundo valor: {Value02}", endMessage: "\n");
                    }
                    if (Value01 != 0 && Value02 == 0)
                    {
                        Console.Clear();
                        Utility.WriteTitle("Division Operation (/)", "\n", "\n\n");
                        Utility.WriteMessage($"Primeiro valor: {Value01}\nOperador: (/)\nSegundo valor: {Value02}", endMessage: "\n");
                        Utility.WriteMessage($"Não existe divisão por {Value02}.", "\n", "\n");
                    }
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

            CalculatorTemplate();
            
        }

        // Método para requisitar ao usuário a inserção dos dados, via console, para uma operação aritmética simples
        internal void AskData()
        {
            ShowOperation();
            
            Utility.WriteMessage($"Primeiro valor: ");
            Value01 = CalculatorUtility.CheckDouble(Console.ReadLine());

            Utility.WriteMessage($"Segundo valor: ");
            Value02 = CalculatorUtility.CheckDouble(Console.ReadLine());
        }

        internal void CalculatorTemplate()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] operators = { "+", "-", "*", "/", "=" };
            int i = Convert.ToInt16(Operator) - 1;

            string display = string.Format(" {0} {1} {2} = {3} ", Value01, operators[i], Value02, Result);
            int displayLength = display.Length + 5;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Utility.WriteMessage(new string('-', displayLength), "", "\n");
            Utility.WriteMessage($"{display}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage(new string('-', displayLength), "", "\n");
            Utility.WriteMessage($" AC (+/ -) %  {operators[3]}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage($" {numbers[7]}    {numbers[8]}    {numbers[9]}  {operators[2]}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage($" {numbers[4]}    {numbers[5]}    {numbers[6]}  {operators[1]}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage($" {numbers[1]}    {numbers[2]}    {numbers[3]}  {operators[0]}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage($" {numbers[0]}         ,  {operators[4]}".PadRight(displayLength), "", "\n");
            Utility.WriteMessage(new string('-', displayLength), "", "\n");
            Console.ResetColor();
            
        }

        #endregion

        #region Destructor

        #endregion
    }
}
