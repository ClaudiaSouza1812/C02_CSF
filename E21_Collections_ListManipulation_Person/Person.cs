using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E21_Collections_ListManipulation_Person
{
    internal class Person
    {
        
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        private string name;

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        internal int Id { get; }
        internal static int NextId { get; set; } = 1;
        #endregion

        #region Classic properties 1.0
        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Bodied-expression properties 3.0
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */
        #endregion
        #endregion

        #region Constructors (public or internal)
        // Fazer substituto do default constructor

        internal Person()
        {
            Id = NextId++;
            Name = string.Empty;
        }

        // Fazer segundo construtor com inserção de parâmetros obrigatórios

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        #endregion

        #region Methods (public or internal)

        internal static void ListPerson(List<Person> list)
        {
            Utility.WriteTitle("Person - List", "\n", "\n\n");

            foreach (Person item in list)
            {
                Utility.WriteMessage($"Id: {item.Id}, Name: {item.Name}", "", "\n");
            }
        }

        internal void AddPerson()
        {
            Console.Clear();
            Utility.WriteTitle("Add a Person", "\n", "\n\n");

            Utility.WriteMessage("Name: ");

            Name = Console.ReadLine();
        }

        // MRS: embora não manipule diretamente as propriedades da pessoa, não deixa de ser um método de Person
        internal static void InsertPersonInPosition(List<Person> list, Person person, string position)
        {
            int number = Convert.ToInt16(position);

            int listLength = list.Count();

            if (number == listLength)
            {
                list.Add(person);
            }
            else if (number < listLength & number >= 0)
            {
                list.Insert(number, person);
            }
            else
            {
                Utility.WriteMessage($"As posições na lista se iniciam em índice (0).", "\n", "\n");
                Utility.WriteMessage($"A lista tem {listLength} posições, insira um valor válido (0 a {listLength}).", "\n", "\n");
            }
        }

        internal static Person FindId(List<Person> list)
        {
            int id = PersonUtility.CheckId();

            foreach (Person person in list)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }

            return null;
        }

        internal static void FindPerson(List<Person> list)
        {
            Console.Clear();
            Utility.WriteTitle("Find person by id", "\n", "\n\n");

            Person person = FindId(list);

            if (person != null)
            {
                Utility.WriteMessage($"O ID ({person.Id}) pertence a ({person.Name}).", "", "\n\n");
            }
            else
            {
                Utility.WriteMessage("O ID digitado não existe", "", "\n\n");
            }
        }

        internal static void RemovePerson(List<Person> list)
        {
            Console.Clear();
            Utility.WriteTitle("Remove person by id", "\n", "\n\n");

            Person person = FindId(list);

            if (person != null)
            {
                Utility.WriteMessage($"A pessoa ({person.Name}) com o ID ({person.Id}) foi removida com sucesso.", "", "\n\n");
                list.Remove(person);
            }
            else
            {
                Utility.WriteMessage("O ID digitado não existe", "", "\n\n");
            }
        }

        internal static void SortId(List<Person> list)
        {
            Console.Clear();
            Utility.WriteTitle("Sort list by id", "\n", "\n");

            if (list.Count() > 0)
            {
                list.Sort((person1, person2) => person1.Id.CompareTo(person2.Id));
                ListPerson(list);
            }
            else
            {
                Utility.WriteMessage("A lista está vazia", "", "\n\n");
            }
        }

        internal static void SortName(List<Person> list)
        {
            Console.Clear();
            Utility.WriteTitle("Sort list by Name", "\n", "\n");

            if (list.Count() > 0)
            {
                list.Sort((person1, person2) => person1.Name.CompareTo(person2.Name));
                ListPerson(list);
            }
            else
            {
                Utility.WriteMessage("A lista está vazia", "", "\n\n");
            }
        }
        #endregion

        #region Destructor

        #endregion
    }
}
