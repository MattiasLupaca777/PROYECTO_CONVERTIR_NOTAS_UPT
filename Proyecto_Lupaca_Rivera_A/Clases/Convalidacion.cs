using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Convalidacion
    {
        public Estudiante Estudiante { get; set; }
        public Movilidad Movilidad { get; set; }

        public List<Equivalencia> Equivalencias { get; set; }

        public Convalidacion()
        {
            Equivalencias = new List<Equivalencia>();
        }

        public int TotalCreditos()
        {
            int total = 0;

            foreach (var item in Equivalencias)
            {
                total += item.Creditos;
            }

            return total;
        }

        public double Promedio()
        {
            if (Equivalencias.Count == 0)
                return 0;

            double suma = 0;

            foreach (var item in Equivalencias)
            {
                suma += item.NotaConvertida;
            }

            return suma / Equivalencias.Count;
        }
    }
}
