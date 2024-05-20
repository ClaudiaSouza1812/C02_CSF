using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E21_Collections_ListManipulation_Person
{
    internal class PersonUtility
    {
        internal static Dictionary<string, string> ShowMenu()
        {
            // MRS: o menu chama-se ShowMenu e no entanto tb está a fazer a leitura e a validação da escolha. Ou mudas o nome ou divides o método

            Console.Clear();
            Utility.WriteTitle("List Manipulation - Person", "", "\n");
            Utility.WriteTitle("Person Menu", "", "\n\n");
            Utility.WriteMessage("Escolha o número de uma das seguintes opções: ", endMessage: "\n\n");

            Dictionary<string, string> dictMenu = new Dictionary<string, string>()
            {
                {"1", "Add person"},
                {"2", "Insert person in position" },
                {"3", "Find person by id" },
                {"4", "Remove person by id" },
                {"5", "Sort list by id" },
                {"6", "Sort list by name" },
                {"7", "List person" },
                {"8", "Exit" }
            };

            foreach (KeyValuePair<string, string> item in dictMenu)
            {
                Utility.WriteMessage($"({item.Key}) {item.Value}", "", "\n");
            }

            return dictMenu;
        }


        internal static string GetMenuChoice()
        {
            string answer;
            bool status;
            do
            {
                Console.Clear();

                ShowMenu();

                Utility.WriteMessage("Opção: ", "\n");
                answer = Console.ReadLine();

                status = CheckInt(answer);

            } while (!status);

            return answer;
        }


        internal static bool CheckInt(string option)
        {
            int choice;
            bool status;
            status = int.TryParse(option, out choice);
            return status;
        }


        internal static string CheckMenuChoice(Dictionary<string, string> menu, string key)
        {
            bool status;
            string choice;
            
            status = menu.TryGetValue(key, out choice);

            if (status)
            {
                return choice;
            }
            else
            {
                return GetMenuChoice();
            }
        }


        internal static string KeepGoing()
        {
            string answer;

            Utility.WriteMessage("Continue? (y/n): ", "\n");
            answer = Console.ReadLine().ToLower();

            return answer;
        }


        internal static string CheckPosition()
        {
            string answer;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Add in position", "", "\n\n");
                Utility.WriteMessage("Digite o número da posição em que deseja inserir a pessoa.", "", "\n\n");
                Utility.WriteMessage("Número: ");
                answer = Console.ReadLine();

            } while (!CheckInt(answer));

            return answer;
        }

        
        internal static int CheckId()
        {
            string answer;
            do
            {
                
                Utility.WriteTitle("Digite o número do ID", "", "\n\n");
                Utility.WriteMessage("Número: ");
                answer = Console.ReadLine();

            } while (!CheckInt(answer));

            return Convert.ToInt16(answer);
        }

        // MRS: os nomes dos métodos devem ser auto explicativos. Este nome não diz nada
        internal static void StartPersonProgram(List<Person> list)
        {
            Dictionary<string, string> menu = ShowMenu();
            string key, option, position;

            do
            {
                key = GetMenuChoice();
                option = CheckMenuChoice(menu, key);

                switch (option)
                {
                    case "Add person":
                        do
                        {
                            Person person = new Person();

                            person.AddPerson();

                            list.Add(person);

                        } while (KeepGoing() == "y");
                        break;

                    case "Insert person in position":
                        do
                        {
                            Person person = new Person();

                            person.AddPerson();

                            position = CheckPosition();

                            Person.InsertPersonInPosition(list, person, position);

                        } while (KeepGoing() == "y");
                        break;

                    case "Find person by id":
                        do
                        {
                            Person.FindPerson(list);

                        } while (KeepGoing() == "y");
                        break;

                    case "Remove person by id":
                        do
                        {
                            Person.RemovePerson(list);

                        } while (KeepGoing() == "y");
                        break;

                    case "Sort list by id":

                        Person.SortId(list);
                        KeepGoing();
                        break;

                    case "Sort list by name":

                        Person.SortName(list);
                        KeepGoing();
                        break;

                    case "List person":

                        Person.ListPerson(list);
                        KeepGoing();
                        break;

                    default:
                        break;
                }

            } while (option != "Exit");

        }

    }
}
