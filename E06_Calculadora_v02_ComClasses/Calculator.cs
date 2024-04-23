using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Calculator
    {
        #region Fields (properties private variables)

        // variáveis internas da classe para serem usadas dentro das propriedades

        /* Example:
        private string address, city, country;
        */

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        // example:
        // public int Id { get; set; }


        #endregion

        #region Classic properties 1.0

        /* example
         public string City
        {
            get { return city; }          // Ler o valor da propriedade
            set { city = value; }         // escrever o valor da propriedade
        }

        City = "teste";         // set
        Console.Write(City);    // get
        */


        #endregion

        #region Bodied-expression properties 3.0

        /* Example
         public string Country
        {
            get => country;             // => lambda operator
            set => country = value;
        }
        */


        #endregion

        #endregion

        #region Constructors (Public)


        /* Examples
        // Substituto do default constructor
        public Person()
        {
            Id = 0;
            Name = string.Empty;
            NIF = string.Empty;
            Phone = "";
            Address = string.Empty;
            City = "";
            Country = string.Empty;
        }

        public Person(int id, string name, string nif, string phone, string address, string city, string country)
        {
            Id = id;
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;
            City = city;
            Country = country;
        }
         */


        #endregion

        #region Methods (public or internal)

        /* Example
         public void PersonWriteData()
        {
            Utility.WriteTitle("Person - list", "\n", "\n\n");

            Utility.WriteMessage($"Person Id: {Id}", "", "\n");
            Utility.WriteMessage($"Person Name: {Name}", "", "\n");
            Utility.WriteMessage($"Person NIF: {NIF}", "", "\n");
            Utility.WriteMessage($"Person Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Person Address: {Address}", "", "\n");
            Utility.WriteMessage($"Person City: {City}", "", "\n");
            Utility.WriteMessage($"Person Country: {Country}", "", "\n");
        }
        */



        #endregion

        #region Destructor

        #endregion
    }
}
