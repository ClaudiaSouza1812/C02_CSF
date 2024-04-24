using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Methods meth01 = new Methods();

            #region Método void

            Utility.WriteTitle("Procedure - método void", "", "\n");
            meth01.Procedure();

            #endregion

            #region Método não void

            Utility.WriteTitle("Function - método não void", "", "\n");

            // v1. 
            //Utility.WriteMessage(meth01.Function().ToString(), "\n", "\n");
            // v2.
            //Utility.WriteMessage($"{meth01.Function()}");

            // v3. Usar esta boa prática
            int res;
            res = meth01.Function();

            Utility.WriteMessage(res.ToString(), "\n", "\n");

            #endregion

            #region Método com parâmetros obrigatórios
            
            Utility.WriteTitle("Método com parâmetros obrigatórios", "\n\n\n", "\n");

            meth01.MethodRequiredParameters("Passagem de parâmetros", "Obrigatórios");

            #endregion

            #region Método com parâmetros opcionais

            Utility.WriteTitle("Método com parâmetros opcionais", "\n\n\n", "\n");

            meth01.MethodOptionalParameters("Passagem de parâmetros");
            #endregion

            #region Método com parâmetros por valor (defeito)

            Utility.WriteTitle("Método com parâmetros por valor", "\n\n\n", "\n");

            int value01 = 1;

            Utility.WriteMessage($"\n1. Valor antes do método: {value01}", "", "\n\n");

            meth01.PassingValues(value01);

            Utility.WriteMessage($"\n3. Valor depois do método: {value01}", "", "\n\n");

            #endregion

            #region Método com parâmetros por referência

            Utility.WriteTitle("Método com parâmetros por referência", "\n\n\n", "\n");

            int value02 = 1;

            Utility.WriteMessage($"1. Valor antes do método: {value02}", "", "\n"); // 1

            meth01.PassingReferences(ref value02);

            Utility.WriteMessage($"3. Valor depois do método: {value02}", "", "\n");    // 10

            #endregion

            #region Método de instância

            // São métodos usados em um objeto intanciado por uma classe

            Utility.WriteTitle("Método de instância", "\n\n\n", "\n");

            // Criar ou chamar o método de instância
            Methods meth02 = new Methods();
            meth02.InstanceMethod();

            #endregion

            #region Método estático
            // método utilizado diretamente na Classe, sem instanciamento de objeto

            Utility.WriteTitle("Método estático", "\n\n\n", "\n");

            Methods.StaticMethod();

            #endregion

            #region Sobrecarga de métodos (overloading)

            Utility.WriteTitle("Métodos com mesmo nome, mas com assinaturas diferentes", "\n\n\n", "\n");

            Methods.WriteNewMessage("Overloading de métodos");

            Methods.WriteNewMessage("Neste exemplo, um método recebe 1 argumento", "O outro método recebe 2 argumentos");


            #endregion

            Utility.TerminateConsole();
        }
    }
}
