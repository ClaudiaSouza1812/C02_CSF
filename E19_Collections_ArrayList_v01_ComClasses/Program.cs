using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E19_Collections_ArrayList_v01_ComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Person - Insert", "\n", "\n\n");

            ArrayList listPerson = new ArrayList();

            string answer, name;
            int id = 1;

            do
            {
                Utility.WriteMessage("Name: ");
                name = Console.ReadLine();
                Person person = new Person(name, id++);

                listPerson.Add(person);

                Utility.WriteMessage("Continue (y/n)? ");
                answer = Console.ReadLine().ToLower();

            } while (answer == "y"); 

            Person.ListPerson(listPerson);


            Utility.TerminateConsole();
        }
    }
}
