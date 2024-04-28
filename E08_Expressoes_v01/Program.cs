using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Expressoes_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Expression exp01 = new Expression();
            exp01.Value01 = 15;
            exp01.Value02 = 2;

            //exp01.ExpressionWriteResult();

            Expression exp02 = new Expression(15, 2);

            exp02.ExpressionWriteResult();
            

            Utility.TerminateConsole();
        }
    }
}
