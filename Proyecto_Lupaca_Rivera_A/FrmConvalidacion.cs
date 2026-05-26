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
using static System.Resources.ResXFileRef;


namespace Proyecto_Lupaca_Rivera_A
{
    public partial class FrmConvalidacion : Form
    {

        List<Convalidacion> lista =
            new List<Convalidacion>();

        // LISTA EQUIVALENCIAS

        List<EquivalenciaNota> equivalencias =
            Archivo.LeerEquivalencias();

        public FrmConvalidacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double nota =
                Convert.ToDouble(
                    txtNotaOriginal.Text);

            string pais =
                cboPais.Text;

            double notaConvertida = 0;

            // BUSCAR RANGO

            foreach (var item in equivalencias)
            {
                if (item.Pais == pais)
                {
                    if (nota >=
                        item.LimiteInferiorExtranjero
                        &&
                        nota <=
                        item.LimiteSuperiorExtranjero)
                    {
                        notaConvertida =

                            Conversor.Convertir(

                            nota,

                            item
                            .LimiteInferiorExtranjero,

                            item
                            .LimiteSuperiorExtranjero,

                            item
                            .LimiteInferiorPeru,

                            item
                            .LimiteSuperiorPeru
                            );
                    }
                }
            }

            // CREAR OBJETO

            Convalidacion c =
                new Convalidacion();

            c.Codigo =
                txtCodigo.Text;

            c.Estudiante =
                txtNombre.Text;

            c.Escuela =
                txtEscuela.Text;

            c.Pais =
                cboPais.Text;

            c.Universidad =
                cboUniversidad.Text;

            c.Semestre =
                cboSemestre.Text;

            c.CursoExtranjero =
                txtCursoExtranjero.Text;

            c.CursoUPT =
                txtCursoUPT.Text;

            c.Creditos =
                Convert.ToInt32(
                    txtCreditos.Text);

            c.NotaOriginal =
                nota;

            c.NotaConvertida =
                notaConvertida;

            // AGREGAR A LISTA

            lista.Add(c);

            // MOSTRAR EN TABLA

            dgvEquivalencias.DataSource =
                null;

            dgvEquivalencias.DataSource =
                lista;

            // CALCULAR

            Calcular();
        }
        private void Calcular()
        {
            int total = 0;

            double suma = 0;

            foreach (var item in lista)
            {
                total += item.Creditos;

                suma += item.NotaConvertida;
            }

            lblTotalCreditos.Text =
                total.ToString();

            if (lista.Count > 0)
            {
                lblPromedio.Text =
                    (suma / lista.Count)
                    .ToString("0.00");
            }
        }

        // ==================================
        // CALCULAR
        // ==================================
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;

            double suma = 0;

            foreach (var item in lista)
            {
                total += item.Creditos;

                suma += item.NotaConvertida;
            }

            lblTotalCreditos.Text =
                total.ToString();

            if (lista.Count > 0)
            {
                lblPromedio.Text =
                    (suma / lista.Count)
                    .ToString("0.00");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                string texto =

                    item.Codigo + "|" +

                    item.Estudiante + "|" +

                    item.Escuela + "|" +

                    item.Pais + "|" +

                    item.Universidad + "|" +

                    item.Semestre + "|" +

                    item.CursoExtranjero + "|" +

                    item.CursoUPT + "|" +

                    item.Creditos + "|" +

                    item.NotaOriginal + "|" +

                    item.NotaConvertida;

                Archivo.Guardar(texto);
            }

            MessageBox.Show("Guardado correctamente");
        }

        private void FrmConvalidacion_Load(object sender, EventArgs e)
        {
            cboPais.Items.Clear();
            cboPais.Items.Add("Argentina");
            cboPais.Items.Add("Bolivia");
            cboPais.Items.Add("Brasil");
            cboPais.Items.Add("Chile");
            cboPais.Items.Add("Colombia");
            cboPais.Items.Add("España");
            cboPais.Items.Add("México");
            cboPais.Items.Add("Perú");

            cboUniversidad.Items.Clear();
            cboUniversidad.Items.Add("Universidad Nacional de Córdoba");
            cboUniversidad.Items.Add("Universidad Mayor de San Andrés");
            cboUniversidad.Items.Add("Universidad de São Paulo");
            cboUniversidad.Items.Add("Universidad de Chile");
            cboUniversidad.Items.Add("Universidad Nacional de Colombia");
            cboUniversidad.Items.Add("Universidad Complutense de Madrid");
            cboUniversidad.Items.Add("UNAM");

            cboSemestre.Items.Clear();
            cboSemestre.Items.Add("2025-I");
            cboSemestre.Items.Add("2025-II");
            cboSemestre.Items.Add("2026-I");
            cboSemestre.Items.Add("2026-II");
            cboSemestre.Items.Add("2027-I");
            cboSemestre.Items.Add("2027-II");

            if (cboPais.Items.Count > 0) cboPais.SelectedIndex = 0;
            if (cboUniversidad.Items.Count > 0) cboUniversidad.SelectedIndex = 0;
            if (cboSemestre.Items.Count > 0) cboSemestre.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquivalencias.CurrentRow
                != null)
            {
                int fila =
                    dgvEquivalencias
                    .CurrentRow.Index;

                lista.RemoveAt(fila);

                dgvEquivalencias
                    .DataSource = null;

                dgvEquivalencias
                    .DataSource = lista;

                Calcular();
            }
        }

        // ==================================
        // NUEVO
        // ==================================

        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            txtCodigo.Clear();

            txtNombre.Clear();

            txtEscuela.Clear();

            txtCursoExtranjero.Clear();

            txtCursoUPT.Clear();

            txtCreditos.Clear();

            txtNotaOriginal.Clear();

            dgvEquivalencias
                .DataSource = null;

            lista.Clear();

            lblTotalCreditos.Text =
                "0";

            lblPromedio.Text =
                "0";
        }

        private void lblTotalCreditos_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtCodigo.Clear();

            txtNombre.Clear();

            txtEscuela.Clear();

            txtCursoExtranjero.Clear();

            txtCursoUPT.Clear();

            txtCreditos.Clear();

            txtNotaOriginal.Clear();

            dgvEquivalencias
                .DataSource = null;

            lista.Clear();

            lblTotalCreditos.Text =
                "0";

            lblPromedio.Text =
                "0";
        }

        // ==================================
        // GUARDAR TXT
        // ==================================
    }
}

