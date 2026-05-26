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
        ArchivoCursos archivo = new ArchivoCursos();

        List<Curso> lista = new List<Curso>();
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
