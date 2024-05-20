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
        internal static string ShowMenu()
        {
            Console.Clear();
            Utility.WriteTitle("List Manipulation - Person", "", "\n");
            Utility.WriteTitle("Person Menu", "", "\n\n");

            string key;
            bool status;
            string choice;

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

            do
            {
                Utility.WriteMessage("Escolha o número de uma das seguintes opções: ", endMessage: "\n\n");

                foreach (KeyValuePair<string, string> item in dictMenu)
                {
                    Utility.WriteMessage($"({item.Key}) {item.Value}", "", "\n");
                }

                Utility.WriteMessage("Opção: ", "\n");

                // Tod MRS: o menu chama-se ShowMenu e no entanto tb está a fazer a leitura e a validação da escolha. Ou mudas o nome ou divides o método
                key = Console.ReadLine();

                status = dictMenu.TryGetValue(key, out choice);

                Console.Clear();

                Utility.WriteTitle("List Manipulation - Person", "", "\n");
                Utility.WriteTitle("Person Menu", "", "\n\n");

            } while (!status);

            return choice;
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
            int result;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Add in position", "", "\n\n");
                Utility.WriteMessage("Digite o número da posição em que deseja inserir a pessoa.", "", "\n\n");
                Utility.WriteMessage("Número: ");

            } while (!int.TryParse(Console.ReadLine(), out result));

            return result.ToString();
        }

        // Todo MRS: embora não manipule diretamente as propriedades da pessoa, não deixa de ser um método de Person
        internal static void InsertInPosition(List<Person> list, Person person, string position)
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

        internal static int CheckId()
        {
            int result;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Digite o número do ID", "", "\n\n");
                Utility.WriteMessage("Número: ");
                

            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }

        // Todo MRS: os nomes dos métodos devem ser auto explicativos. Este nome não diz nada
        internal static void RunProgram(List<Person> list)
        {
            string position;
            string option = ShowMenu();

            do
            {
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

                            InsertInPosition(list, person, position);

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

                option = ShowMenu();

            } while (option != "Exit");

            Console.Clear();
        }

    }
}
