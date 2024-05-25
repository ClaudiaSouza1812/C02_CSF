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
            Utility.SetUnicodeConsole();        
            
            /*
            List<Person> personsList = new List<Person>()
            {
                new Person()
                {
                    Name = "Claudia"
                }

            };
            Person person = new Person();
            person.Name = "Paula";
            personsList.Add(person);

            personsList.Add(new Person("Ana"));
            */

            List<Person> personsList = new List<Person>();
            PersonUtility.StartPersonProgram(personsList);

            Utility.TerminateConsole();
        }
    }
}
