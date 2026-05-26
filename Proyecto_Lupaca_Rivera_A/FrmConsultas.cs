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
    public partial class FrmConsultas : Form
    {
        // 🔥 CREAR LISTA
        List<Convalidacion> lista =
            new List<Convalidacion>();

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resultado =
                lista.Where(x =>
                x.Estudiante.ToLower()
                .Contains(
                    txtEstudiante.Text.ToLower()))
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = resultado;
        }
        

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            lista = Archivo.Leer();

            dgvConsultas.DataSource = lista;
        }
    }
}
