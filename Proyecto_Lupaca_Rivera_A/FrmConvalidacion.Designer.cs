namespace Proyecto_Lupaca_Rivera_A
{
    partial class FrmConvalidacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEscuela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboUniversidad = new System.Windows.Forms.ComboBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.colCursoExtranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoUPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaConvertida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEscuela);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del estudiante";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtEscuela
            // 
            this.txtEscuela.Location = new System.Drawing.Point(108, 124);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(100, 20);
            this.txtEscuela.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escuela";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudAnio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboSemestre);
            this.groupBox2.Controls.Add(this.cboUniversidad);
            this.groupBox2.Controls.Add(this.cboPais);
            this.groupBox2.Location = new System.Drawing.Point(327, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 172);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Movilidad";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(105, 16);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 21);
            this.cboPais.TabIndex = 0;
            // 
            // cboUniversidad
            // 
            this.cboUniversidad.FormattingEnabled = true;
            this.cboUniversidad.Location = new System.Drawing.Point(105, 46);
            this.cboUniversidad.Name = "cboUniversidad";
            this.cboUniversidad.Size = new System.Drawing.Size(121, 21);
            this.cboUniversidad.TabIndex = 1;
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(105, 80);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(121, 21);
            this.cboSemestre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Universidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semestre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(105, 117);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCursoExtranjero,
            this.colCursoUPT,
            this.colCreditos,
            this.colNotaOriginal,
            this.colNotaConvertida});
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(120, 386);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // colCursoExtranjero
            // 
            this.colCursoExtranjero.HeaderText = "Curso Extranjero";
            this.colCursoExtranjero.Name = "colCursoExtranjero";
            this.colCursoExtranjero.ReadOnly = true;
            // 
            // colCursoUPT
            // 
            this.colCursoUPT.HeaderText = "Curso UPT";
            this.colCursoUPT.Name = "colCursoUPT";
            this.colCursoUPT.ReadOnly = true;
            // 
            // colCreditos
            // 
            this.colCreditos.HeaderText = "Creditos";
            this.colCreditos.Name = "colCreditos";
            this.colCreditos.ReadOnly = true;
            // 
            // colNotaOriginal
            // 
            this.colNotaOriginal.HeaderText = "Nota Original";
            this.colNotaOriginal.Name = "colNotaOriginal";
            this.colNotaOriginal.ReadOnly = true;
            // 
            // colNotaConvertida
            // 
            this.colNotaConvertida.HeaderText = "Nota Convertida";
            this.colNotaConvertida.Name = "colNotaConvertida";
            this.colNotaConvertida.ReadOnly = true;
            // 
            // FrmConvalidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConvalidacion";
            this.Text = "FrmConvalidacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEscuela;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.ComboBox cboUniversidad;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoExtranjero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoUPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaConvertida;
    }
}