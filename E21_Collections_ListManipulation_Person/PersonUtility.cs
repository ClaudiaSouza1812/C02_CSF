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
            Utility.WriteTitle("Person list", "", "\n\n");

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

                Utility.WriteMessage("Opção: ");

                key = Console.ReadLine();

                status = dictMenu.TryGetValue(key, out choice);

                Console.Clear();

            } while (!status);

            return choice;
        }


        internal static string KeepGoing()
        {
            string answer;

            Utility.WriteMessage("Continue? (y/n): ");
            answer = Console.ReadLine().ToLower();

            return answer;
        }


        internal static string AddPosition()
        {
            int result;

            do
            {
                Console.Clear();
                Utility.WriteMessage("Digite o número da posição em que deseja inserir a pessoa.", "", "\n");

                Utility.WriteMessage("Número: ");
            } while (!int.TryParse(Console.ReadLine(), out result));


            return result.ToString();
        }


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
                Utility.WriteMessage($"A lista tem {listLength} posições, insira um valor válido.");
            }
        }


    }
}
