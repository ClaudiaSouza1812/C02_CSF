using D00_Utility;
using System;
using System.Net.Http.Headers;

namespace E06_Calculadora_v02_ComClasses
{

    internal class Calculator
    {

        #region Fields
        private double value01;
        private double value02;
        private double v1, v2;
        #endregion

        #region Properties
        internal double Value01
        {
            get { return value01; }
            set { value01 = value; }
        }

        internal double Value02
        {
            get { return value02; }
            set { value02 = value; }
        }

        internal string Operation { get; set; }
        
        internal double Result { get; set; }
        #endregion

        #region Constructors
        internal Calculator()
        {

            Value01 = 0;
            Value02 = 0;
            Result = 0;
            Operation = "";

        }
        #endregion

        #region Methods        
        internal void ReadValues()
        {
            
            do
            {                
                Utility.WriteMessage("Value 1: ", "\n\n\n");                
            }
            while (!double.TryParse(Console.ReadLine(), out value01));

            do
            {
                Utility.WriteMessage("Value 2: ", "\n");
            } while (!double.TryParse(Console.ReadLine(), out value02));

        }

        internal void Calculate()
        {

            switch (Operation)
            {                
                case "1":
                    Add();
                    break;
                case "2":
                    Subtract();
                    break;
                case "3":
                    Multiply();
                    break;
                case "4":
                    Divide();
                    break;
            }

        }

        internal void Add()
        {

            Result = Value01 + Value02;

            /*
                // v1
                return Value01 + Value02;

                // v2
                double result;
                result = Value01 + Value02;
                return result;
            */

        }

        internal void Subtract()
        {

            Result = Value01 - Value02;

        }

        internal void Multiply()
        {

            Result = Value01 * Value02;

        }

        internal void Divide()
        {

            if (Value02 == 0)
            {
                Result = 0;
            }
            else
            {
                Result = Value01 / Value02;
            }

        }

        internal void ShowResult()
        {

            Utility.WriteMessage($"Result: {Result}", "\n", "\n");

        }
        #endregion

    }

}
