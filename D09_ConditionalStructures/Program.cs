using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_ConditionalStructures
{

    internal class Program
    {

        static void Main(string[] args)
        {
            
            Utility.SetUnicodeConsole();

            #region Variáveis
            int numero = 0;
            int valor01 = 1;
            int valor02 = 2;
            bool resultado = true;
            #endregion

            #region If Simples
            Utility.WriteTitle("If Simples");

            if (numero == 0)
            {
                Utility.WriteMessage("O número é 0.");
            }

            if (numero == 10)
            {
                Utility.WriteMessage("O número é 10.");
            }

            if (numero != 2)
            {
                Utility.WriteMessage("O número não é 2.");
            }

            #endregion

            #region If Else
            Utility.WriteTitle("If Else");

            if (numero == 100)
            {
                Utility.WriteMessage("O número é igual a 100.");
            }
            else
            {
                Console.WriteLine("O número é diferente de 100.");
            }
            #endregion

            #region Operador Ternário
            Utility.WriteTitle("Operador Ternário");

            /* Clássico
            if (valor01 == valor02)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            */

            // Se 2 valores são iguais           
            resultado = valor01 == valor02 ? true : false;      // result = expression ? T : F

            Utility.WriteMessage(resultado.ToString());
            #endregion

            #region Ifs Encadeados

            if (numero == 0)
            {
                Utility.WriteMessage("O número é igual a 0.");
            }
            else
            {
                if (numero == 5)
                {
                    Utility.WriteMessage("O número é igual a 5.");
                }
                else
                {
                    if (numero == 10)
                    {
                        Utility.WriteMessage("O número é igual a 10.");
                    }
                    else
                    {
                        if (numero == 15)
                        {
                            Utility.WriteMessage("O número é igual a 15.");
                        }
                        else
                        {
                            Utility.WriteMessage("O número não é: 0, 5, 10, 15.");
                        }
                    }
                }
            }

            #endregion

            #region If ElseIf

            #endregion

            #region Switch
            // ToDo MRS: Se o nº for entre 1 e 4 dizer o seu extenso

            switch (numero)
            {
                case 0:
                    Utility.WriteMessage("O número é igual a 0.");
                    break;
                case 4:
                    Utility.WriteMessage("")
                case 5:
                    Utility.WriteMessage("O número é igual a 5.");
                    break;
                case 10:
                    Utility.WriteMessage("O número é igual a 10.");
                    break;
                case 15:
                    Utility.WriteMessage("O número é igual a 15.");
                    break;
                default:
                    Utility.WriteMessage("O número não é: 0, 5, 10, 15.");
                    break;
            }
            #endregion

            Utility.TerminateConsole();

        }

    }

}
