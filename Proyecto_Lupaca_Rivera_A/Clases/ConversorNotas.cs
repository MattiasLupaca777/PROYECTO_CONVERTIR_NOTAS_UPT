using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class ConversorNotas
    {
        public static double ConvertirNota(
                    double notaExtranjera,
                    double limiteInferiorExtranjero,
                    double limiteSuperiorExtranjero,
                    double limiteInferiorPeru,
                    double limiteSuperiorPeru)
        {

            double notaPeru =
                limiteInferiorPeru +
                (
                (notaExtranjera - limiteInferiorExtranjero)
                /
                (limiteSuperiorExtranjero - limiteInferiorExtranjero)
                )
                *
                (limiteSuperiorPeru - limiteInferiorPeru);

            return Math.Round(notaPeru, 2);
        }
    }
}
    
