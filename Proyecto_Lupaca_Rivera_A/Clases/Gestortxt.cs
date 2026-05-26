using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    internal class Gestortxt
    {
        public static void Guardar(string ruta, string contenido)
        {
            StreamWriter sw = new StreamWriter(ruta);

            sw.WriteLine(contenido);

            sw.Close();
        }
    }
}
