using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace D13_AccessModifiers
{
    internal class User
    {
        /*
         1 field para suportar a propriedade RegistrationDate
            6 properties: Id, Name, Department, RegistrationDate,  Username e Password
            2 constructors
            2 methods: CreateUser e ListUser
         */

        #region Fields (properties, private variables)

        // variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)

        private DateTime registrationDate;

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        // Declarar uma propriedade usando Auto-implemented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        #region Classic properties 1.0

        // Declarar uma propriedade usando Classic properties
        public DateTime RegistrationDate
        {
            get { return registrationDate; }     // Ler o valor da propriedade
            set { registrationDate = value; }    // escrever o valor da propriedade
        }

        #endregion

        #region Bodied-expression properties 3.0

        // Declarar uma propriedade usando Bodied-expression properties
        /*public double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }*/

        #endregion

        #endregion

        #region Constructors (Public)

        // Substituto do default constructor
        public User()
        {
            Id = 0;
            Name = string.Empty;
            Department = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            RegistrationDate = DateTime.Today;
        }

        // Segundo construtor com inserção parâmetros obrigatórios
        public User(int id, string name, string department, string username, string password, DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Department = department;
            Username = username;
            Password = password;
            RegistrationDate = registrationDate;
        }
        #endregion

        #region Methods (public or internal)

        // Método para criar um usuário
        
        public void CreateUser()
        {
            Utility.WriteTitle("User - Creation", endTitle: "\n\n");

            int i = 0;
            string[] properties = { "id", "name", "department", "username", "password", "registrationDate" };
            string[] userData = new string[properties.Length];

            foreach (string prop in properties)
            {
                if (prop == "id")
                {
                    Utility.WriteMessage($"Insira o {prop} do usuário: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    userData[i] = Convert.ToString(id);
                    i++;
                }
                else
                {
                    Utility.WriteMessage($"Insira o {prop} do usuário: ");
                    userData[i] = Console.ReadLine();
                    i++;
                }
            }
            
        }

        // Método para mostrar o usuário
        public void ListUser()
        {
            Utility.WriteTitle("User - Show Data", "\n", "\n\n");

            Utility.WriteMessage($"Id: {Id}\nNome: {Name}\nDepartamento: {Department}\nNome do Usuário: {Username}\nSenha: {Password}\nData do Registro: {RegistrationDate}");
        }

        
        #endregion

        #region Destructor

        #endregion

    }
}
