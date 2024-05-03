// Todo MRS: Complicaste demasiado algo que se quer simples, embora estruturado.
// Todo MRS: Tens de pensar melhor na responsabilidade da classe e de cada um dos métodos, antes de implementares e evitares criar métodos que não acrescentam valor ao algoritmo.

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

        // variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)

        private double value01, value02;
        
        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        // Declarar uma propriedade usando Auto-implemented properties
        public string Operators { get; set; }    // Todo MRS: propriedade no singular

        #endregion

        #region Classic properties 1.0

        // Declarar uma propriedade usando Classic properties
        public double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }

        #endregion

        #region Bodied-expression properties 3.0

        // Declarar uma propriedade usando Bodied-expression properties
        public double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }

        #endregion

        #endregion

        #region Constructors (Public)

        // Substituto do default constructor
        public Calculator()
        {
            Value01 = 0;
            Value02 = 0;
            Operators = string.Empty;
        }

        // Segundo construtor com inserção parâmetros obrigatórios
        public Calculator(double value01, double value02, string operators)
        {
            Value01 = value01;
            Value02 = value02;
            Operators = operators;
        }
        #endregion

        #region Methods (public or internal)
        
        // Todo MRS: Uma vez que os valores estão nas propriedades, não faz sentido enviar como parameters para o método        
        // Todo MRS: Os 4 métodos artiméticos têm a responsabilidade de gerar um resultado pelo cálculo efetuado. Logo, este método só tem a responsabilidade de os invocar, não de ficar com o resultado
            
        // Método para devolver o resultado de uma operação aritmética simples
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

        // Todo MRS: Ontem falei desta particularidade, que seria mais eficaz criar uma propriedade adicional do resultado e usar nos métodos aritméticos
        
        // Método para devolver a soma de dois valores
        public double Sum(double value01, double value02)
        {
            double result;
            result = value01 + value02;
            return result;
        }

        // Método para devolver a subtração de dois valores
        public double Sub(double value01, double value02)
        {
            double result;
            result = value01 - value02;
            return result;
        }

        // Método para devolver a multiplicação de dois valores
        public double Multi(double value01, double value02)
        {
            double result;
            result = value01 * value02;
            return result;
        }

        // Método para devolver a divisão de dois valores
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
                return result;
            }
        }

        // Todo MRS: Podes fazer este método, mas nesse caso, retira-o da classe, porque não manipula diretamente os seus dados. Vai para uma classe utilitária do Calculator
        
        // Método para checar e devolver um double
        internal double CheckDouble(bool status, string input, string valor)
        {
            double reference;
            status = double.TryParse(input, out reference);
            while (status == false)
            {
                Utility.WriteMessage($"Você digitou '{input}', entre um valor numérico.", "", "\n");
                Utility.WriteMessage($"{valor}: ");
                input = Console.ReadLine();
                status = double.TryParse(input, out reference);
            }

            reference = Convert.ToDouble(input);
            return reference;
        }

        // Todo MRS: Vimos isto ontem
        
        // Método para checar e devolver um operador
        internal string CheckOperators(string input, bool status)
        {
            /*tentar foreach
             * string[] opers = { "+", "-", "+", "/" };

            foreach (var item in opers)
            {
                
            }*/
            while (status == false)
            {
                switch (input)
                {
                    case "+":
                        status = true;
                        break;
                    case "-":
                        status = true;
                        break;
                    case "*":
                        status = true;
                        break;
                    case "/":
                        status = true;
                        break;
                    default:
                        Utility.WriteMessage($"Você digitou {input}, entre um dos 4 operadores válidos acima.", "", "\n");
                        Utility.WriteMessage("Operador: ");
                        input = Console.ReadLine();
                        break;
                }
            }
            return input;
        }

        // Todo MRS: Para quê este overload (2 versões diferentes) do método  CalculatorWriteResult()?
        
        // Método para mostrar no console o resultado de uma operação aritmética simples
        public void CalculatorWriteResult()
        {
            Utility.WriteTitle("Calculator - result", endTitle:"\n\n");

            double result;
            
            Utility.WriteMessage($"Você inseriu os valores ({Value01}), ({Value02}) e o operador ({Operators}).", endMessage: "\n\n");

            result = Operations(Value01, Value02, Operators);

            Utility.WriteMessage($"Resultado: {Value01} {Operators} {Value02} = {result}", endMessage: "\n");
        }

        // Todo MRS: Se é um método para mostrar o resultado, não devia estar a obter o resultado aqui. E mais uma vez, se as propriedades já têm valores, não devem ser enviados os parameters
        
        // Método para mostrar no console o resultado de uma operação aritmética simples
        public void CalculatorWriteResult(double value01, double value02, string operators)
        {
            Utility.WriteTitle("Calculator - result", "\n", "\n\n");

            double result;

            Utility.WriteMessage($"Você inseriu os valores ({value01}), ({value02}) e o operador ({operators}).", endMessage: "\n\n");

            result = Operations(value01, value02, operators);

            Utility.WriteMessage($"Resultado: {value01} {operators} {value02} = {result}", endMessage: "\n");
        }

        // Todo MRS: Tentar validar os valores da consola e guardar diretamente nas propriedades, em vez de andar a criar variáveis. Não esquecer que este é um exercício simples e estás a complicar.
        
        // Método para requisitar ao usuário a inserção dos dados, via console, para uma operação aritmética simples
        public void CalculatorReadData()
        {
            Utility.WriteTitle("Calculator - set the new calculation data", endTitle: "\n\n");

            bool status = false;
            string input;
            string valor = "Primeiro valor";

            Utility.WriteMessage("Insira os 2 valores desejados e um dos seguintes operadores: ", endMessage: "\n\n");

            // Todo MRS: Isto devia ser um menu de escolha da operação
            
            Utility.WriteMessage("Soma: \"+\"\nSubtração: \"-\"\nMultiplicação: \"*\"\nDivisão: \"/\"\n", endMessage: "\n");

            Utility.WriteMessage($"{valor}: ");
            input = Console.ReadLine();

            Value01 = CheckDouble(status, input, valor);

            valor = "Segundo valor";
            Utility.WriteMessage($"{valor}: ");
            input = Console.ReadLine();

            Value02 = CheckDouble(status, input, valor);

            Utility.WriteMessage("Operador: ");
            input = Console.ReadLine();

            Operators = CheckOperators(input, status);

            CalculatorWriteResult(Value01, Value02, Operators);
        }

        #endregion

        #region Destructor

        #endregion
    }
}
