using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Movilidad
    {
        public string Pais { get; set; }
        public string Universidad { get; set; }
        public string Semestre { get; set; }
        public int Año { get; set; }

        public Movilidad()
        {

        }

        public Movilidad(string pais, string universidad, string semestre, int año)
        {
            Pais = pais;
            Universidad = universidad;
            Semestre = semestre;
            Año = año;
        }
    }
}
