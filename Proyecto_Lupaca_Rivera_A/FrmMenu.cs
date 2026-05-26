using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCursos());
        }

        private void btnConvalidacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConvalidacion());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultas());

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEstadisticas());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
