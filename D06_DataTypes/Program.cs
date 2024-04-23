using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D06_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region 1. Declarar variáveis e criar objetos
            byte idade;     //0 - 255
            float altura;
            double peso;

            bool inscrito;  // true (1) | false (0)

            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;

            string nomeCompleto;    // isto é um objeto
            #endregion

            #region 2. Atribuir valores
            // números
            idade = 41;
            altura = 20.5F;
            peso = 75.00;

            // booleano
            inscrito = true;

            // data
            data = new DateTime(2024, 04, 1);
            hora = new DateTime(2024, 4, 1, 19, 5, 0);
            agora = DateTime.Now;           // timestamp: data + hora
            dataAtual = DateTime.Today;     // data apenas
            dataVazia = DateTime.MinValue;  // menor data possivel: 0001/1/1 12:00:00 AM

            // string
            nomeCompleto = "c";

            #endregion

            #region 3. Declarar e atribuir
            string horario = "19:00 - 22:30";
            #endregion

            #region 4. Vetor (single dimentional array)

            Utility.WriteTitle("Vetor");

            // Guardar 4 nomes
            string[] nomes = new string[4]; // 4 linhas, começando em 0
            int[] numeros = new int[4];     // 4 linhas, começando em 0

            nomes[0] = "Ana";
            nomes[1] = "Milena";
            nomes[2] = "Amélia";
            Utility.WriteMessage("Apelido: ");
            nomes[3] = Console.ReadLine();

    
            for (int i = 0; i < nomes.Length; i++)
            {
                Utility.WriteMessage($"{nomes[i]} ");
            }
            

            // for para atribuir valores ao vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
            };

            // for para escrever na consola

            for (int i = 0; i < numeros.Length; i++) 
            {
                Utility.WriteMessage($"Valor{i + 1}: {numeros[i]}", "\n");
            }

            #endregion

            #region 5. Matriz (multi dimentional array)

            string[,] turma = new string[4, 2];

            // primeiro numero: linha, segundo número: coluna
            turma[0, 0] = "Ana";
            turma[0, 1] = "Porto";
            turma[1, 0] = "Milena";
            turma[1, 1] = "Espinho";
            turma[2, 0] = "Amélia";
            turma[2, 1] = "Braga";

            Utility.WriteMessage("Nome: ", "\n");
            turma[3, 0] = Console.ReadLine();

            Utility.WriteMessage("Distrito: ");
            turma[3, 1] = Console.ReadLine();


            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Utility.WriteMessage($"{turma[row, col]}\t");
                };
                Utility.WriteMessage("", "", "\n");
            };

            #endregion

            #region 6. Trabalhar na consola

            
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Variáveis numéricas");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\nByte - idade: " + idade);    // Não concatenar com o '+'
            // string interpolation: safe concatenation

            Console.WriteLine($"Float - altura: {altura}");

            Console.WriteLine($"Double - peso: {peso}\n");

            Utility.WriteTitle("Variáveis booleana");

            // Usar utility nas mensagens

            Utility.WriteMessage("\n", $"Boolean - inscrito: {inscrito}", "\n");
           
            Utility.WriteTitle("Variáveis string");

            // As strings são imutáveis (endereço de memória que não sabemos, na heap)
            // Deve-se concatenar strings com a classe StringBuilder e o método Add
            nomeCompleto = nomeCompleto + " rs";    // concatenação: teremos 'm' em um endereço de memória e 'm rs' em outro endereço de memória;
            Utility.WriteMessage($"String - nome completo: {nomeCompleto}");
            Utility.WriteMessage($"String - horário: {horario}", "\n", "\n\n");

            Utility.WriteTitle("Variáveis data e hora");

            Console.WriteLine($"0. Date - data: {data}");
            Utility.WriteMessage($"1. Date - data: {data}", "\n", "\n");
            Utility.WriteMessage($"2. Date - data: {data}", "", "\n\n\n");
            Utility.WriteMessage($"3. Date - data: {data}", beginMessage: "\n\n\n");
            Utility.WriteMessage($"4. Date - data: {data}", "\n\n","\n");
            Utility.WriteMessage($"5. Date - data: {data}", "", "\n\n");



            Utility.WriteMessage($"Long date - data: {data.ToLongDateString()}", "", "\n");
            Utility.WriteMessage($"Short - data: {data.ToShortDateString()}", "", "\n");

            Utility.WriteMessage($"Time - horas: {hora}", "", "\n");
            Utility.WriteMessage($"Long time - horas: {hora.ToLongTimeString()}", "", "\n");
            Utility.WriteMessage($"Short time - horas: {hora.ToShortTimeString()}", "", "\n");

            Utility.WriteMessage($"Date - agora: {agora}", "", "\n");
            Utility.WriteMessage($"Date - data atual: {dataAtual}", "", "\n");
            Utility.WriteMessage($"Date - data vazia: {dataVazia}", "", "\n");

            Utility.WriteMessage($"Year: {agora.Year}", "", "\n");
            Utility.WriteMessage($"Month: {agora.Month}", "", "\n");
            Utility.WriteMessage($"Day: {agora.Day}", "", "\n");
            Utility.WriteMessage($"Hour: {agora.Hour}", "", "\n");
            Utility.WriteMessage($"Minute: {agora.Minute}", "", "\n");
            Utility.WriteMessage($"Second: {agora.Second}", "", "\n");

            #endregion

            Utility.TerminateConsole();
        }
    }
}
