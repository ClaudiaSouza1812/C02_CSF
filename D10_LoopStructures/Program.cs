using System;
using System.Collections.ObjectModel;
using D00_Utility;

namespace D10_LoopStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            string string01 = "";
            string string02 = "x";
            string name = string.Empty;
            #endregion

            #region WHILE (enquanto a condição for verdadeira)
            // O teste é feito no início
            // Não garante que seja feito pelo menos uma única vez

            

            while (string01 != "x")
            {
                Console.Clear();
                Utility.WriteTitle("WHILE");
                Utility.WriteMessage("Para saíres escreve x: ", "\n");
                string01 = Console.ReadLine();
            }

            Utility.TerminateConsole();

            #endregion

            #region DO...WHILE (repetir até)
            // O teste é feito no fim
            // Garante que é feito pelo menos 1 vez
            Utility.WriteTitle("DO...WHILE");

            do
            {
                Utility.WriteMessage("Para saíres escreve x: ", "\n");
                string02 = Console.ReadLine();
            } while (string02 != "x");

            Utility.TerminateConsole();
            #endregion

            #region FOR (para)
            // Repetir x número de vezes
            Utility.WriteTitle("FOR");

            // asc
            for (int i = 0; i < 3; i++)    // i++    i = i + 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.WriteMessage("\n");

            // desc
            for (int i = 2; i >= 0; i--)    // i--  i = i - 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.TerminateConsole();
            #endregion

            #region FOREACH (para cada elemento; usado com arrays e collections)
            // Percorrer todos os elementos dum array ou duma collection

            int[] numeros = { 3, 10, 1, 20, 0, 4 };

            string[] palavras =
            {
                "a",
                "b",
                "c"
            };

            int[] valores = new int[3];

            valores[0] = 10;
            valores[1] = 100;
            valores[2] = 1000;
            
            foreach (int item in numeros)
            {
                Utility.WriteMessage(item.ToString(), "\n");
            }

            // strongly typed (variável fortemente tipada)

            foreach (int item in numeros)
            {
                Utility.WriteMessage(item.ToString(), "\n");
            };


            foreach (int number in valores)
            {
                Utility.WriteMessage(number.ToString(), "\n");
            };

            foreach (string word in palavras)
            {
                Utility.WriteMessage(word, "\n");
            };

            #endregion

            Utility.TerminateConsole();

        }

    }

}
