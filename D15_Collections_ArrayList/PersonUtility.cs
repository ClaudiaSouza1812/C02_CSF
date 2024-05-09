using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class PersonUtility
    {
        #region Methods
        // Metodo para listar as coleções (que não são Person)

        internal static void ListData(ArrayList list)
        {
            foreach (var item in list)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }
        }

        #endregion
    }
}
