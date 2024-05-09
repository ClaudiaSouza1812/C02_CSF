using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Utility.SetUnicodeConsole();

            #region ArrayList: multi tipos + inteiros

            // 1. instanciar array list
            // 2. invoque a classe array list

            ArrayList listMulti = new ArrayList();
            ArrayList listIntegers = new ArrayList();

            // 3.  Adicionar valores de tipos diferentes (um a um)

            listMulti.Add(10);
            listMulti.Add("a");
            listMulti.Add(false);
            listMulti.Add(DateTime.Today);

            // 4. Adicionar 5 valores do tipo inteiro automaticamente

            for (int i = 0; i < 5; i++)
            {
                listIntegers.Add(i);
            }

            // listIntegers.Add("Vou dar cabo desta lista!");  // Mostra a vulnerabilidade da arra list
            listIntegers.Add(-30);
            listIntegers.Add(19);

            // 5. Quantos elementos há na lista?

            Utility.WriteTitle("ArrayList contagem", "", "\n\n");

            Utility.WriteMessage($"Nº de elementos - listMulti: {listMulti.Count}", "", "\n");

            Utility.WriteMessage($"Nº de elementos - listIntegers: {listIntegers.Count}", "", "\n\n");

            // 6. Listar

            Utility.WriteTitle("ArrayList - listMulti", "", "\n\n");
            PersonUtility.ListData(listMulti);

            Utility.WriteTitle("ArrayList - listIntegers", "", "\n\n");
            PersonUtility.ListData(listIntegers);

            // 7. Listar, ordenado

            Utility.WriteTitle("ArrayList - listIntegers ordenada", "", "\n");
            listIntegers.Sort();
            PersonUtility.ListData(listIntegers);

            #endregion

            #region Persons: objects of class Person

            // Criar 2 pessoas
            
            ArrayList list = new ArrayList();

            Person person01 = new Person("Claudia", "Coimbra");
            Person person02 = new Person();

            person02.Name = "Paula";
            person02.City = "Coimbra";

            list.Add(person01);
            list.Add(person02);

            // Listar
            Utility.WriteTitle("ArrayList - Person", "", "\n");

            // PersonUtility.ListData(listPerson);

            Person.ListPerson(list);

            #endregion

            Utility.TerminateConsole();

        }
    }
}
