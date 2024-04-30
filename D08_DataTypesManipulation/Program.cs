using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D08_DataTypesManipulation
{

    internal class Program
    {
    
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis

            #region Strings
            string area = "Informática";
            string categoria = "Linguagens de programação";
            string curso = "C# Foundations";
            string cursoCompleto00;     // +
            string cursoCompleto01;     // string interpolation
            string cursoCompleto02;     // string.join
            string cursoCompleto03;     // string.concat
            string cursoCompleto05;     // string.format
            StringBuilder cursoCompleto04 = new StringBuilder();
            #endregion

            #region Numbers
            int valor01 = 10;
            int valor02 = 100;
            double valor03 = 2.3;
            double valor04 = -12.1;
            double valor05 = 64;
            double valor06 = 4;
            #endregion
            
            #region Datetime
            DateTime timestamp = DateTime.Now;
            #endregion

            #endregion

            #region Manipulação de strings

            #region Clássico: evitar se houver concatenação de strings nas variáveis
            // Operador + NÃO USAR!!!
            cursoCompleto00 = area + ", " + categoria + ", " + curso;

            // String interpolation
            cursoCompleto01 = $"{area}, {categoria}, {curso}";

            // string.Concat()
            cursoCompleto03 = string.Concat(area, " - ", categoria, ", ", curso);   // T-SQL Concat()
            
            // string.Join()
            cursoCompleto02 = string.Join(", ", area, categoria, curso);            // T-SQL Concat_Ws()

            // string.format()
            cursoCompleto05 = string.Format("Curso completo: {0} - {1}, {2} ", area, categoria, curso);

            #endregion

            #region Ótima - classe StringBuilder
            cursoCompleto04.Append(area);
            cursoCompleto04.Append("\t");
            cursoCompleto04.Append(categoria);
            cursoCompleto04.Append("\t");
            cursoCompleto04.Append(curso);
            #endregion

            #region Mostrar na consola
            Utility.WriteTitle("manipulação de strings");
            Utility.WriteMessage($"Maiúsculas: {cursoCompleto01.ToUpper()}");
            Utility.WriteMessage($"Maiúsculas: {cursoCompleto02.ToLower()}");
            Utility.WriteMessage($"Esquerda (fixo): {cursoCompleto03.Substring(0, 11)}");        // Left; Informática
            Utility.WriteMessage($"Esquerda (dinâmico): {cursoCompleto02.Substring(0, cursoCompleto02.IndexOf(","))}");
            Utility.WriteMessage($"Curso: {cursoCompleto04}");
            Utility.WriteMessage($"Curso: {cursoCompleto05}");
            #endregion

            #endregion

            #region Manipulação de numbers
            Utility.WriteTitle("Manipulação de numbers", "\n\n\n");
            Utility.WriteMessage($"Mínimo: {Math.Min(valor01, valor02)}");
            Utility.WriteMessage($"Maximo: {Math.Max(valor01, valor02)}");
            Utility.WriteMessage($"Absoluto: {Math.Abs(valor04)}");
            Utility.WriteMessage($"Arredondamento: {Math.Round(valor03)}");
            Utility.WriteMessage($"Raíz quadrada: {Math.Sqrt(valor06)}");

            #endregion

            #region Manipulação de datetime
            Utility.WriteTitle("manipulação de datetime", "\n\n\n");
            Utility.WriteMessage($"Minutos + 10: {timestamp.AddMinutes(10).Minute}");
            Utility.WriteMessage($"Próxima hora: {timestamp.AddHours(1).Hour}");
            #endregion

            Utility.TerminateConsole();

        }

    }

}
