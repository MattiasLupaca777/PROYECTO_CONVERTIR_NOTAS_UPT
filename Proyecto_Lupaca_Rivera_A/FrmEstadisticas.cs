using Proyecto_Lupaca_Rivera_A.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lupaca_Rivera_A
{
    public partial class FrmEstadisticas : Form
    {
        List<Convalidacion> lista =
    new List<Convalidacion>();
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            chart1.Series.Add("País");

            int bolivia = 0;
            int chile = 0;

            foreach (var item in lista)
            {
                if (item.Pais == "Bolivia")
                {
                    bolivia++;
                }

                if (item.Pais == "Chile")
                {
                    chile++;
                }
            }

            chart1.Series["País"]
                .Points.AddXY(
                    "Bolivia",
                    bolivia);

            chart1.Series["País"]
                .Points.AddXY(
                    "Chile",
                    chile);
        }
    }
}
