using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_CollectionsGeneric_List
{
    internal class CourseUtility
    {
        /*
        -----------
        OVERLOADING
        -----------
        Em vez de termos métodos com nomes diferentes e objetos iguais, temos métodos com o mesmo nome e assinaturas diferentes
        */
        internal static void ListData(List<int> list)
        {
            foreach (int item in list)
            {
                Utility.WriteMessage($"Integer: {item}", "", "\n");
            }
        }

        internal static void ListData(List<string> list)
        {
            foreach (string item in list)
            {
                Utility.WriteMessage($"String: {item}", "", "\n");
            }
        }
    }
}
