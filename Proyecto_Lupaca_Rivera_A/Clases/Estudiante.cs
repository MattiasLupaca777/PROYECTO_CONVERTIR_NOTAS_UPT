using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Estudiante
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Escuela { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string codigo, string nombre, string escuela)
        {
            Codigo = codigo;
            Nombre = nombre;
            Escuela = escuela;
        }
    }
}
