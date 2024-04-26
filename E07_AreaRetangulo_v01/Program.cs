using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E07_AreaRetangulo_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();


            Area area01 = new Area();
            
            area01.Altura = 4;
            area01.Largura = 8;

            Area area02 = new Area(6.5, 12.5);

            Area area03 = new Area();

            area03.AreaReadData();

            //area01.AreaWriteResult();
            //area02.AreaWriteResult();

            Utility.TerminateConsole();
        }
    }
}
