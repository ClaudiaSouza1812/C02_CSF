using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08_Expressoes_v01
{
    internal class Expression
    {
        #region Fields (properties, private variables)
        // variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0

        public double Value01 { get; set; }
        public double Value02 { get; set; }


        #endregion
        #region Classic properties1.0

        #endregion
        #region Bodied-expression properties 3.0

        #endregion

        #endregion

        #region Constructors (public)

        public Expression()
        {
            Value01 = 0;
            Value02 = 0;
        }

        public Expression(double value01, double value02)
        {
            Value01 = value01;
            Value02 = value02;
        }

        #endregion

        #region Methods (public or internal)

        public double Sum(double value01, double value02)
        {
            return value01 + value02;
        }

        public double Div(double value01, double value02)
        {
            return value01 / value02;
        }

        public double Rest(double value01, double value02)
        {
            return value01 % value02;
        }

        public void ExpressionWriteResult()
        {
            Utility.WriteTitle("Escrever um programa que apresente no ecrã o resultado de expressões dadas", "", "\n\n");

            double exp01, exp02, exp03;

            exp01 = Value01 + Value02;
            exp02 = Value01 / Value02;
            exp03 = Value01 % Value02;

            Utility.WriteMessage($"Primeira expressão: {Value01} + {Value02} = {exp01}", "", "\n");
            Utility.WriteMessage($"Segunda expressão: {Value01} / {Value02} = {exp02}", "", "\n");
            Utility.WriteMessage($"Terceira expressão: {Value01} % {Value02} = {exp03}", "", "\n");
        }

        public void ExpressionReadData()
        {

        }

        #endregion

        #region Destructor

        #endregion
    }
}
