using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E22_FutureAge_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Show user age in 20 years","", "\n\n");

            int age;
            bool success;

            Utility.WriteMessage("Insert your age: ");
            success = int.TryParse(Console.ReadLine(), out age);

            if (success)
            {
                Utility.WriteMessage($"Your age in 20 years will be: {age+20}.", "\n", "\n");
            }
            else 
            {
                Utility.WriteMessage("Insert a valid age.");
            }

            Utility.TerminateConsole();
        }
    }
}
