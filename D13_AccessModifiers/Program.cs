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

            Utility.PauseConsole();

            User user02 = new User(1, "Claudia", "TI", "claudiasimone", "123456", DateTime.Today);
            user02.ListUser();

            Utility.TerminateConsole();
        }
    }
}
