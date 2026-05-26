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

            cboPais.Items.Clear();
            cboPais.Items.Add("--- Todos ---"); // Opción para no filtrar
            cboPais.Items.Add("Argentina");
            cboPais.Items.Add("Bolivia");
            cboPais.Items.Add("Brasil");
            cboPais.Items.Add("Chile");
            cboPais.Items.Add("Colombia");
            cboPais.Items.Add("España");
            cboPais.Items.Add("México");
            cboPais.Items.Add("Perú");

            cboUniversidad.Items.Clear();
            cboUniversidad.Items.Add("--- Todas ---"); // Opción para no filtrar
            cboUniversidad.Items.Add("Universidad Nacional de Córdoba");
            cboUniversidad.Items.Add("Universidad Mayor de San Andrés");
            cboUniversidad.Items.Add("Universidad de São Paulo");
            cboUniversidad.Items.Add("Universidad de Chile");
            cboUniversidad.Items.Add("Universidad Nacional de Colombia");
            cboUniversidad.Items.Add("Universidad Complutense de Madrid");
            cboUniversidad.Items.Add("UNAM");

            // 3. CARGAR COMBOBOX DE SEMESTRES PARA CONSULTAS
            cboSemestre.Items.Clear();
            cboSemestre.Items.Add("--- Todos ---"); // Opción para no filtrar
            cboSemestre.Items.Add("2025-I");
            cboSemestre.Items.Add("2025-II");
            cboSemestre.Items.Add("2026-I");
            cboSemestre.Items.Add("2026-II");
            cboSemestre.Items.Add("2027-I");
            cboSemestre.Items.Add("2027-II");

            // Seleccionar la opción "--- Todos ---" por defecto al abrir la ventana
            cboPais.SelectedIndex = 0;
            cboUniversidad.SelectedIndex = 0;
            cboSemestre.SelectedIndex = 0;
        }
    }
}
