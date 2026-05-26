using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lupaca_Rivera_A.Clases
{
    /*internal class Conversor
    {
    }*/
    public class Conversor
    {
        public static double Convertir(
            double nota,

            double liExt,

            double lsExt,

            double liPeru,

            double lsPeru)
        {
            double resultado;

            resultado =

                liPeru +

                (

                (nota - liExt)

                /

                (lsExt - liExt)

                )

                *

                (lsPeru - liPeru);

            return Math.Round(
                resultado,
                2);
        }
    }
}