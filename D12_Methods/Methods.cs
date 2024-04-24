using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Methods
    {
        #region Método void

        public void Procedure()
        {
            string message = "Procedimento: método void que não retorna valor.";
            Utility.WriteMessage($"{message}", "", "\n\n");
        }

        public void WrongProcedure()
        {
            string message = "Função: método não void, que retorna valor.";
            Utility.WriteMessage($"{message}", "", "\n\n");

            int v1, v2, res;
            v1 = 10;
            v2 = 20;
            res = v1 + v2;

            Utility.WriteMessage(res.ToString());
        }

        #endregion

        #region Método não void

        public int Function()
        {
            string message = "Procedimento: método não void, que retorna valor.";
            Utility.WriteMessage($"{message}", "", "\n\n");

            int v1, v2, res;
            v1 = 10;
            v2 = 20;
            res = v1 + v2;

            return res;
        }

        #endregion

        #region Método com parâmetros obrigatórios

        public void MethodRequiredParameters(string message01, string message02)
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n");
        }

        #endregion

        #region Método com parâmetros opcionais

        public void MethodOptionalParameters(string message01, string message02 = "")
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n");
        }

        #endregion

        #region Método com parâmetros por valor (defeito)

        public void PassingValues(int value)
        {
            value = 10; // mudar o valor numa cópia da vaiável e não na variável original

            Utility.WriteMessage($"\n2. Valor dentro do método: {value}", "", "\n\n");  // 10
        }

        #endregion

        #region Método com parâmetros por referência

        public void PassingReferences(ref int value)
        {
            value = 10; // mudar o valor implica mudar em todas as referências

            Utility.WriteMessage($"2. Valor dentro do método: {value}", "", "\n");  // 10
        }

        #endregion

        #region Método de instância

        public void InstanceMethod()
        {
            Utility.WriteMessage("Um método de instancia é chamado através de um objeto (instancia) da classe.", "", "\n");
        }

        #endregion

        #region Método estático

        public static void StaticMethod()
        {
            Utility.WriteMessage("Um método estático é chamado diretamente da classe.", "", "\n");
        }


        #endregion

        #region Sobrecarga de métodos (overloading)

        public static void WriteNewMessage(string message)
        {
            message = message.ToUpper();
            Utility.WriteMessage(message, "", "\n");
        }

        public static void WriteNewMessage(string message01, string message02)
        {
            message01 = message01.ToLower();
            message02 = message02.ToLower();
            Utility.WriteMessage($"{message01} {message02}", "", "\n");
        }
        #endregion








    }
}
