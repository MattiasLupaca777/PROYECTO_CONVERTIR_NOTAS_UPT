using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    /*internal class Archivo
    {
    }*/
    public class Archivo
    {
        // GUARDAR CONVALIDACIONES

        public static void Guardar(string texto)
        {
            StreamWriter sw =
                new StreamWriter(
                    "convalidaciones.txt",
                    true);

            sw.WriteLine(texto);

            sw.Close();
        }

        // LEER CONVALIDACIONES

        public static List<Convalidacion> Leer()
        {
            List<Convalidacion> lista =
                new List<Convalidacion>();

            if (File.Exists(
                "convalidaciones.txt"))
            {
                StreamReader sr =
                    new StreamReader(
                        "convalidaciones.txt");

                while (!sr.EndOfStream)
                {
                    string linea =
                        sr.ReadLine();

                    string[] datos =
                        linea.Split('|');

                    Convalidacion c =
                        new Convalidacion();

                    c.Codigo = datos[0];
                    c.Estudiante = datos[1];
                    c.Escuela = datos[2];
                    c.Pais = datos[3];
                    c.Universidad = datos[4];
                    c.Semestre = datos[5];
                    c.CursoExtranjero = datos[6];
                    c.CursoUPT = datos[7];
                    c.Creditos =
                        Convert.ToInt32(
                        datos[8]);

                    c.NotaOriginal =
                        Convert.ToDouble(
                        datos[9]);

                    c.NotaConvertida =
                        Convert.ToDouble(
                        datos[10]);

                    lista.Add(c);
                }

                sr.Close();
            }

            return lista;
        }

        // =========================
        // LEER EQUIVALENCIAS
        // =========================

        public static
        List<EquivalenciaNota>
        LeerEquivalencias()
        {
            List<EquivalenciaNota>
                lista =

                new List<EquivalenciaNota>();

            if (File.Exists(
                "equivalencias.txt"))
            {
                StreamReader sr =
                    new StreamReader(
                        "equivalencias.txt");

                while (!sr.EndOfStream)
                {
                    string linea =
                        sr.ReadLine();

                    string[] datos =
                        linea.Split('|');

                    EquivalenciaNota e =
                        new EquivalenciaNota();

                    e.Pais = datos[0];

                    e.LimiteInferiorExtranjero =
                        Convert.ToDouble(
                        datos[1]);

                    e.LimiteSuperiorExtranjero =
                        Convert.ToDouble(
                        datos[2]);

                    e.LimiteInferiorPeru =
                        Convert.ToDouble(
                        datos[3]);

                    e.LimiteSuperiorPeru =
                        Convert.ToDouble(
                        datos[4]);

                    lista.Add(e);
                }

                sr.Close();
            }

            return lista;
        }
    }
}