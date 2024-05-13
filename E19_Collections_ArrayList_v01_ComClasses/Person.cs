using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E19_Collections_ArrayList_v01_ComClasses
{
    internal class Person
    {

        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        int Id { get; set; }
        string Name { get; set; }
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
            Id = 0;        
            Name = string.Empty;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios

        internal Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        #endregion

        #region Methods (public or internal)

        internal void AskPerson()
        {
            Utility.WriteMessage("Name: ");
            Name = Console.ReadLine();
        }

        internal static void ListPerson(ArrayList list)
        {
            Utility.WriteTitle("Person - list", "\n", "\n\n");

            foreach (Person item in list)
            {
                Utility.WriteMessage($"{item.Id}, {item.Name}", "", "\n");
            }
        }

        #endregion

        #region Destructor

        #endregion



    }
}
