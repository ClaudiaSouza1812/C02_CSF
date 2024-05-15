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

        // Fazer segundo construtor com inserção parâmetros obrigatórios

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

        

        #endregion

        #region Destructor

        #endregion
    }
}
