using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }

        public Curso()
        {

        }

        public Curso(string codigo, string nombre, int creditos)
        {
            Codigo = codigo;
            Nombre = nombre;
            Creditos = creditos;
        }
    }
}
