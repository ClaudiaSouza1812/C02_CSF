using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Calculator
    {
        #region Fields (properties, private variables)

        // variáveis internas da classe para serem usadas dentro das propriedades

        /* Example:
        private string address, city, country;
        */

        private double value01, value02;
        private string operators;

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        // example:
        // public int Id { get; set; }

        public double Value01 { get; set; }
        public double Value02 { get; set; }
        public string Operators { get; set; }
        

        #endregion

        #region Classic properties 1.0

        /* example
         public string City
        {
            get { return city; }          // Ler o valor da propriedade
            set { city = value; }         // escrever o valor da propriedade
        }

        City = "teste";         // set
        Console.Write(City);    // get
        */


        #endregion

        #region Bodied-expression properties 3.0

        /* Example
         public string Country
        {
            get => country;             // => lambda operator
            set => country = value;
        }
        */


        #endregion

        #endregion

        #region Constructors (Public)


        /* Examples
        // Substituto do default constructor
        public Person()
        {
            Id = 0;
            Name = string.Empty;
            NIF = string.Empty;
            Phone = "";
            Address = string.Empty;
            City = "";
            Country = string.Empty;
        }

        public Person(int id, string name, string nif, string phone, string address, string city, string country)
        {
            Id = id;
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;
            City = city;
            Country = country;
        }
         */
        public Calculator()
        {
            Value01 = 0;
            Value02 = 0;
            Operators = string.Empty;
        }

        public Calculator(double value01, double value02, string operators)
        {
            Value01 = value01;
            Value02 = value02;
            Operators = operators;
        }
        #endregion

        #region Methods (public or internal)

        /* Example
         public void PersonWriteData()
        {
            Utility.WriteTitle("Person - list", "\n", "\n\n");

            Utility.WriteMessage($"Person Id: {Id}", "", "\n");
            Utility.WriteMessage($"Person Name: {Name}", "", "\n");
            Utility.WriteMessage($"Person NIF: {NIF}", "", "\n");
            Utility.WriteMessage($"Person Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Person Address: {Address}", "", "\n");
            Utility.WriteMessage($"Person City: {City}", "", "\n");
            Utility.WriteMessage($"Person Country: {Country}", "", "\n");
        }
        */

        public double Operations(double value01, double value02, string operators)
        {
            double result;

            switch (operators)
            {
                case "+":
                    result = Sum(value01, value02);
                    break;
                case "-":
                    result = Sub(value01, value02);
                    break;
                case "*":
                    result = Multi(value01, value02);
                    break;
                case "/":
                    result = Div(value01, value02);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        public double Sum(double value01, double value02)
        {
            double result;
            result = value01 + value02;
            return result;
        }

        public double Sub(double value01, double value02)
        {
            double result;
            result = value01 - value02;
            return result;
        }

        public double Multi(double value01, double value02)
        {
            double result;
            result = value01 * value02;
            return result;
        }

        public double Div(double value01, double value02)
        {
            double result;
            result = value01 / value02;

            if (Value02 == 0)
            {
                Utility.WriteMessage($"Não existe divisão por {Value02}.", endMessage: "\n\n");
                return result;
            }
            else
            {
                return 0;
            }
        }
        

        public void CalculatorWriteResult()
        {
            Utility.WriteTitle("Calculator - result", endTitle:"\n\n");

            double result;
            
            Utility.WriteMessage($"Você inseriu os valores ({Value01}), ({Value02}) e o operador ({Operators}).", endMessage: "\n\n");

            result = Operations(Value01, Value02, Operators);

            Utility.WriteMessage($"Resultado: {Value01} {Operators} {Value02} = {result}", endMessage: "\n");
        }

        public void CalculatorReadData()
        {
            Utility.WriteTitle("Calculator - set the new calculation data", endTitle: "\n\n");

            Utility.WriteMessage("Insira os 2 valores desejados e um dos seguintes operadores: ", endMessage: "\n\n");

            Utility.WriteMessage("Soma: \"+\"\nSubtração: \"-\"\nMultiplicação: \"*\"\nDivisão: \"/\"\nResultado: \"=\"\n", endMessage: "\n");

            Utility.WriteMessage("Primeiro valor: ");
            Value01 = Convert.ToDouble(Console.ReadLine());

            /*status = int.TryParse(input, out number);
            while (status == false)
            {
                Utility.WriteMessage($"Você digitou '{input}', entre um {properties[i]} numérico.", "\n", "\n");
                Utility.WriteMessage($"Person {properties[i]}: ");
                input = Console.ReadLine();
                status = int.TryParse(input, out number);*/

                Utility.WriteMessage("Segundo valor: ");
            Value02 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Operador: ");
            Operators = Console.ReadLine();


        }

        #endregion

        #region Destructor

        #endregion
    }
}
