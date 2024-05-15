using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_CollectionsGeneric_List
{
    internal class Course
    {
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        internal string Code { get; set; }
        internal string Area { get; set; }  
        internal string Title { get; set; } 
        #endregion

        #region Classic properties 1.0
        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        
        #endregion

        #region Bodied-expression properties 3.0
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */

        
        #endregion
        #endregion

        #region Constructors (public or internal)
        // Fazer substituto do default constructor

        internal Course()
        {
            Code = string.Empty;
            Area = string.Empty;
            Title = string.Empty;
        }

        // Fazer segundo construtor com inserção parâmetros obrigatórios

        internal Course(string code, string area, string title)
        {
            Code = code;
            Area = area;
            Title = title;
        }

        #endregion

        #region Methods (public or internal)

        internal static void ListCourse(List<Course> list)
        {
            Utility.WriteTitle("List<course>", "\n", "\n\n");

            foreach (Course item in list)
            {
                Utility.WriteMessage($"Course: {item.Code}, {item.Area}, {item.Title}", "", "\n");
            }
        }

        #endregion
    }
}
