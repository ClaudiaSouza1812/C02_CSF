using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            User user01 = new User();
            //user01.CreateUser();

            User user02 = new User(1, "Claudia", "TI", "claudiasimone", "123456", new DateTime(2024, 04, 04));

            user02.ListUser();
            Utility.TerminateConsole();
        }
    }
}
