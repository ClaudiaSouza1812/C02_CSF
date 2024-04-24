using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            // 1. instanciar a classe Person (cria objetos da classe Person na memória) e posteriormente atribuir os valores

            // Instanciar a classe 
            Person person01 = new Person();     // Person(): método construtor (especial) vazio

            // atribuir os valores
            person01.Id = 1;
            person01.Name = "Pessoa 1";
            person01.NIF = "123456789";
            person01.Phone = "123456789";
            person01.Address = "Rua Aqui, 10";
            person01.City = "Cidade Sei Lá";
            person01.Country = "Será?";

            // 2. Instanciar a classe Person com o 2º construtor imediatamente passar os valores como argumentos

            Person person02 = new Person(2, "Paula");

            // 3. Instanciar a classe Person com o 3º construtor e imediatamente passar os valores como argumentos

            Person person03 = new Person(3, "Claudia", "987654321", "987654321", "Praceta Garcia, 2b", "Coimbra", "Portugal");

            // 4. Pedir os dados da pessoa

            Person person04 = new Person();

            
            // 5. Usar os métodos

            person04.PersonReadData();
            person04.PersonWriteData();
            Utility.TerminateConsole();
        }
    }
}
