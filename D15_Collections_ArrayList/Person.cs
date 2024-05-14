using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Person
    {
        /*
        internal static int NextId { get; set; } = 1;
        internal int Id { get; set; }

        internal Person(string name)
        {
            ID = nextid++;
            Name = name;
        }
        

        */
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        private string name, city;
        
        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

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

        internal string City
        {
            get => city;
            set => city = value;
        }
        #endregion
        #endregion

        #region Constructors (public or internal)
        // Fazer substituto do default constructor

        internal Person()
        {
            Name = string.Empty;
            City = string.Empty;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios

        internal Person(string name, string city)
        {
            Name = name;
            City = city;
        }

        #endregion

        #region Methods (public or internal)

        internal static void ListPerson(ArrayList list)
        {
            foreach (Person item in list)
            {
                Utility.WriteMessage($"{item.Name}, {item.City}", "", "\n");
            }
        }

        #endregion

        #region Destructor

        #endregion
    }
}
