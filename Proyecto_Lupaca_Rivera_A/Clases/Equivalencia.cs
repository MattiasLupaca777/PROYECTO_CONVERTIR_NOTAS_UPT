using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Equivalencia
    {
        public string CursoExtranjero { get; set; }
        public string CursoUPT { get; set; }
        public int Creditos { get; set; }
        public double NotaOriginal { get; set; }
        public double NotaConvertida { get; set; }

        public Equivalencia()
        {

        }

        public Equivalencia(string cursoExtranjero,
                            string cursoUPT,
                            int creditos,
                            double notaOriginal,
                            double notaConvertida)
        {
            CursoExtranjero = cursoExtranjero;
            CursoUPT = cursoUPT;
            Creditos = creditos;
            NotaOriginal = notaOriginal;
            NotaConvertida = notaConvertida;
        }
    }
}
