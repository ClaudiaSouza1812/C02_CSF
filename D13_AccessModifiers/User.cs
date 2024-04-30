using D00_Utility;
using System;
using System.Collections.Generic;
using System.IO;
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

        private DateTime registrationDate;  // suporte á propriedade RegistrationDate

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        // Declarar uma propriedade usando Auto-implemented properties
        public int Id { get; }  // read-only
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

        #endregion

        #endregion

        #region Constructors (Public)

        // Substituto do default constructor
        public User()
        {
            Id = 1;
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

            bool status = false;

            Utility.WriteMessage("Insira o nome do usuário: ");
            Name = Console.ReadLine();

            Utility.WriteMessage("Insira o departamento do usuário: ");
            Department = Console.ReadLine();

            Utility.WriteMessage("Insira o username do usuário: ");
            Username = Console.ReadLine();

            Utility.WriteMessage("Insira a senha do usuário: ");
            Password = Console.ReadLine();

            do
            {
                Utility.WriteMessage($"Insira a data de registro do usuário: ");
                status = DateTime.TryParse(Console.ReadLine(), out registrationDate);
                        
            } while (status != true);

            RegistrationDate = registrationDate;
        }

        // Método para mostrar o usuário
        public void ListUser()
        {
            Utility.WriteTitle("User - Show Data", "\n", "\n\n");

            Utility.WriteMessage($"Id: {Id}\nNome: {Name}\nDepartamento: {Department}\nNome do Usuário: {Username}\nSenha: {Password}\nData do Registro: {RegistrationDate}");
        }

        /*
         public void CreateUser()
        {
            Utility.WriteTitle("User - Creation", endTitle: "\n\n");

            int i = 0;
            bool status = false;

            string[] properties = { "nome", "departamento", "usuário", "senha", "Data Registro" };
            string[] userData = new string[properties.Length];

            foreach (string prop in properties)
            {
                if (prop == "Data Registro")
                {
                    do
                    {
                        Utility.WriteMessage($"Insira o(a) {prop} do usuário: ");
                        status = DateTime.TryParse(Console.ReadLine(), out registrationDate);
                        
                    } while (status != true);

                    RegistrationDate = registrationDate;
                }
                else
                {
                    Utility.WriteMessage($"Insira o(a) {prop} do usuário: ");
                    userData[i] = Console.ReadLine();
                    i++;
                }
            }

            Name = userData[0];
            Department = userData[1];
            Username = userData[2];
            Password = userData[3];
        }
         */
        #endregion

        #region Destructor

        #endregion

    }
}
