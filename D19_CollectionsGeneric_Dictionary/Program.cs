using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D19_CollectionsGeneric_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Dictionary: criar e carregar os valores iniciais

            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>()
            {
                {"PT", "Portugal"},
                {"BR", "Brasil"},
                {"ES", "Espanha"},
                {"MZ", "Moçambique"},
            };

            dictionaryCountries.Add("CV", "Cabo Verde");


            #endregion

            #region Dictionary: listar
            Utility.WriteTitle("Dictionary<string, string> - listagem 1", "", "\n\n");

            DictionaryUtility.ShowDictionary(dictionaryCountries);


            #endregion

            #region Dictionary: inserir um pais se não existir e listar

            string key = "PT";

            if (DictionaryUtility.FindKey(dictionaryCountries, key))
            {
                Utility.WriteMessage($"País duplicado: {key} - {dictionaryCountries[key]}", "\n\n", "");
            }
            else
            {
                string value = "Angola";
                DictionaryUtility.InsertDictionaryEntry(dictionaryCountries, key, value);

                Utility.WriteTitle("Dictionary<string, string> - Listagem 2", "", "\n\n");

                DictionaryUtility.ShowDictionary(dictionaryCountries);
            }

            #endregion
            Utility.TerminateConsole();

            
        }
    }
}
