using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_AreaRetangulo_v01
{
    internal class Area
    {
        #region Fields (properties, private variables)

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0

        public double Altura { get; set; }
        public double Largura { get; set; }


        #endregion

        #region Classic properties 1.0

        #endregion

        #region Bodied-expression properties 3.0

        #endregion

        #endregion

        #region Constructors (Public)

        // Substituto do default constructor
        public Area()
        {
            Altura = 0;
            Largura = 0;
        }

        // Segundo construtor com inserção parâmetros obrigatórios

        public Area(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        #endregion

        #region Methods (public or internal)

        public double AreaResult(double altura, double largura)
        {
            return altura * largura;
        }

        public void AreaWriteResult()
        {
            double area;
            Utility.WriteTitle("Rectangle Area - result", endTitle:"\n\n");

            Utility.WriteMessage($"Você inseriu os valores: Altura ({Altura}), Largura ({Largura}).", endMessage:"\n\n");

            area = Altura * Largura;

            Utility.WriteMessage($"Cálculo para achar a área:\n{Altura} * {Largura} = {area}", endMessage: "\n\n");

            Utility.WriteMessage($"A área do retângulo é: {area}", endMessage: "\n\n");
        }

        public void AreaReadData()
        {
            Utility.WriteTitle("Apresentar a área de um retângulo a partir de dois valores (altura e largura).", endTitle: "\n\n");

            double altura, largura, area;

            Utility.WriteMessage("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            area = AreaResult(altura, largura);

            Utility.WriteMessage($"A área é: {area}.", "\n", "\n");
        }

        #endregion

        #region Destructor

        #endregion

    }
}
