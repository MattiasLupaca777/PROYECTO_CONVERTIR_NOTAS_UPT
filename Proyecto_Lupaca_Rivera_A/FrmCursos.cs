using Proyecto_Lupaca_Rivera_A.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Lupaca_Rivera_A
{
    public partial class FrmCursos : Form
    {
        List<Curso> listaCursos = new List<Curso>();

        public FrmCursos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();

            c.Codigo = txtCodigo.Text;
            c.Nombre = txtNombre.Text;
            c.Creditos = (int)nudCreditos.Value;

            listaCursos.Add(c);

            dgvCursos.DataSource = null;
            dgvCursos.DataSource = listaCursos;

            // Limpiar campos después de agregar
            txtCodigo.Clear();
            txtNombre.Clear();
            nudCreditos.Value = 0;
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
          /*  Datos.ListaCursos = GestorTXT.LeerCursos();
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = Datos.ListaCursos;*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                int fila = dgvCursos.CurrentRow.Index;

                if (fila >= 0 && fila < listaCursos.Count)
                {
                    listaCursos.RemoveAt(fila);
                    dgvCursos.DataSource = null;
                    dgvCursos.DataSource = listaCursos;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            nudCreditos.Value = 0;
        }
    }
}