/*
    CLASS ELEMENTS:
        Attributes or fields    = variáveis privadas da classe (suporte às propriedades)
        Properties              = caraterísticas
        Methods                 = funcionalidades
        Constructors            = funcionalidade invocada aquando da criação do objeto
        Destructor              = funcionalidade que permite indicar como é que o objeto é destruído
    EXEMPLO
        Classe: Produto
        Objects (instâncias da classe): Produto1, Produto2, Produto3...
        Properties: Nome, Cor, Unidade, ...
        Methods: Inserir, Pesquisar, Editar, Apagar, ...
        Constructor: Cor = verde
        Destructor (log): informar que o objeto vai ser destruído

 */
using D00_Utility;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D11_Classes
{
    internal class Person
    {
        #region Fields (properties private variables)

        // varieadades internas da classe para serem usadas dentro das propriedades
        private string address, city, country;

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string NIF { get; set; }

        #endregion

        #region Classic properties 1.0

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        
        public string City
        {
            get { return city; }          // Ler o valor da propriedade
            set { city = value; }         // escrever o valor da propriedade
        }

        /*
            Name = "teste";         // set
            Console.Write(Name);    // get
        */

        #endregion

        #region Bodied-expression properties 3.0
        public string Country
        {
            get => country;             // => lambda operator
            set => country = value;
        }


        #endregion


        #endregion

        #region Constructors (Public)

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

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region Methods (public or internal)


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

        // fazer o método person read data (inserção das informações pelo usuário através do console)

        /* Milena's version
        public void PersonReadData()
        {
            Utility.WriteTitle("Person - read", "\n", "\n\n");

            Utility.WriteMessage($"Person Id: ");
            Id = Convert.ToInt16(Console.ReadLine());

            Utility.WriteMessage($"Person Name: ");
            Name = Console.ReadLine();

            Utility.WriteMessage($"Person NIF: ");
            NIF = Console.ReadLine();

            Utility.WriteMessage($"Person Phone: ");
            Phone = Console.ReadLine();

            Utility.WriteMessage($"Person Address: ");
            Address = Console.ReadLine();

            Utility.WriteMessage($"Person City: ");
            City = Console.ReadLine();

            Utility.WriteMessage($"Person Country: ");
            Country = Console.ReadLine();

        }
        */
            

        // My version
        public void PersonReadData()
        {
            // Display the title
            Utility.WriteTitle("Set the new Person properties", "", "\n\n");

            // Declare needed variables
            bool status;
            int number;
            string input;
            string[] properties = { "Id", "Name", "NIF", "Phone", "Address", "City", "Country" };
            string[] userData = { };

            // Ask user for the data and make the data types verifications

            for (int i = 0; i < properties.Length; i++)
            {
                Utility.WriteMessage($"Person {properties[i]}: ");
                input = Console.ReadLine();

                if (i == 0 || i == 2 || i == 3)
                {
                    status = int.TryParse(input, out number);
                    while (status == false)
                    {
                        Utility.WriteMessage($"Você digitou '{input}', entre um {properties[i]} numérico.", "\n", "\n");
                        Utility.WriteMessage($"Person {properties[i]}: ");
                        input = Console.ReadLine();
                        status = int.TryParse(input, out number);
                    }
                    userData.Append(input);
                }
                else if (i == 1 || i == 5 || i == 6)
                {
                    status = false;
                    while (status == false || string.IsNullOrWhiteSpace(input))
                    {
                        foreach (char item in input)
                        {
                            if (char.IsLetter(item))
                            {
                                status = true;
                                continue;
                            }
                            else
                            {
                                Utility.WriteMessage($"Você digitou '{input}', entre um {properties[i]} alfabético.", "\n", "\n");
                                status = false;
                                Utility.WriteMessage($"Person {properties[i]}: ");
                                input = Console.ReadLine();
                                break;
                            }
                        }
                    }
                    userData.Append(input);
                }
                else 
                {
                    userData.Append(input);
                }

                
            }

            Id = Convert.ToInt16(userData[0]);
            Name = userData[1];
            NIF = userData[2];
            Phone = userData[3];
            Address = userData[4];
            City = userData[5];
            Country = userData[6];
            
            
        }
         
         


        /* Dinamically version
         public void PersonReadData(Person person)
        {
            Utility.WriteTitle("Set the new Person properties", "", "\n\n");

            PropertyInfo[] properties = typeof(Person).GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                Utility.WriteMessage($"Enter {properties[i].Name}: ");
                string userInput = Console.ReadLine();

                properties[i].SetValue(person, Convert.ChangeType(userInput, properties[i].PropertyType));
            }

            person.PersonWriteData();

        }
         */


        #endregion

        #region Destructor

        #endregion
    }
}
