using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_CollectionsGeneric_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<tipe of data>

            Utility.SetUnicodeConsole();

            #region List<int>

            // instanciar, adicionar depois
            List<int> listIntegers = new List<int>();

            // adicionar multi linhas em ciclo

            for (int i = 1; i < 3; i++)
            {
                listIntegers.Add(i);
            }

            // Adicionar 1 elemento posteriormente com numero auto incrementado
            listIntegers.Add(listIntegers.Count + 1);

            // Adicionar 1 elemento porteriormente 
            listIntegers.Add(4);

            Utility.WriteTitle("List<int>", "\n", "\n\n");

            CourseUtility.ListData(listIntegers);

            #endregion

            #region List<string>
            // adicionar multi linhas
            // instanciar e imediatamente adicionar elementos
            List<string> listStrings = new List<string>
            { 
                "a",
                "b",
                "c"
            };

            // Adicionar 1 elemento porteriormente
            listStrings.Add("d");

            Utility.WriteTitle("List<string>", "\n", "\n\n");

            CourseUtility.ListData(listStrings);


            #endregion

            #region List<Course>
            // adicionar multi elementos
            List<Course> listCourses = new List<Course>
            {
                new Course("C01", "DB", "Database Fundamentals"),
                new Course("C02", "DB", "Querying with SQL"),
                new Course("C03", "Dev", "C# Fundamentals"),
            };

            // adicionar 1 elemento posteriormente

            Course course04 = new Course("C04", "Dev", "Data access with Entity Framework");
            listCourses.Add(course04);

            Course.ListCourse(listCourses);
            /*
            List<Course> listCourses = new List<Course>();

            Course course01 = new Course("C01", "DB", "Database Fundamentals");
            Course course02 = new Course("C02", "DB", "Querying with SQL");
            Course course03 = new Course("C03", "Dev", "C# Fundamentals");
            Course course04 = new Course("C04", "Dev", "Data access with Entity Framework");
            */
            #endregion


            Utility.TerminateConsole();
        }
    }
}
