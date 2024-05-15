using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E21_Collections_ListManipulation_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. add person
            2. Insert person in position
            3. Find person by id
            4. Remove person by id
            5. Sort list by id
            6. Sort list by name
            7. List person
            8. Exit

            */
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("List Manipulation - Person", "", "\n");

            List<Person> personsList = new List<Person>()
            { 
                new Person()
                {
                    Name = "Claudia"
                }
            
            };

            /*
            Person person = new Person();
            person.Name = "Paula";
            personsList.Add(person);

            personsList.Add(new Person("Ana"));
            */

            string choice;

            do
            {
                Person person = new Person();

                person.AddPerson();
                
                personsList.Add(person);

                Utility.WriteMessage("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");

            

            Person.ListPerson(personsList);


            Utility.TerminateConsole();
        }
    }
}
