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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscuela = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.cboUniversidad = new System.Windows.Forms.ComboBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.dgvEquivalencias = new System.Windows.Forms.DataGridView();
            this.colCursoExtranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoUPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaConvertida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCursoExtranjero = new System.Windows.Forms.TextBox();
            this.txtCursoUPT = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNotaOriginal = new System.Windows.Forms.TextBox();
            this.lblTotalCreditos = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquivalencias)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(296, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escuela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
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
            // txtEscuela
            // 
            this.txtEscuela.Location = new System.Drawing.Point(108, 88);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(100, 20);
            this.txtEscuela.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
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
            this.groupBox2.Size = new System.Drawing.Size(241, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Movilidad";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(105, 117);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semestre";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pais";
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(105, 80);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(121, 21);
            this.cboSemestre.TabIndex = 2;
            // 
            // cboUniversidad
            // 
            this.cboUniversidad.FormattingEnabled = true;
            this.cboUniversidad.Location = new System.Drawing.Point(105, 46);
            this.cboUniversidad.Name = "cboUniversidad";
            this.cboUniversidad.Size = new System.Drawing.Size(121, 21);
            this.cboUniversidad.TabIndex = 1;
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(105, 16);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 21);
            this.cboPais.TabIndex = 0;
            // 
            // dgvEquivalencias
            // 
            this.dgvEquivalencias.AllowUserToAddRows = false;
            this.dgvEquivalencias.AllowUserToDeleteRows = false;
            this.dgvEquivalencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquivalencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCursoExtranjero,
            this.colCursoUPT,
            this.colCreditos,
            this.colNotaOriginal,
            this.colNotaConvertida});
            this.dgvEquivalencias.Location = new System.Drawing.Point(19, 243);
            this.dgvEquivalencias.Name = "dgvEquivalencias";
            this.dgvEquivalencias.ReadOnly = true;
            this.dgvEquivalencias.Size = new System.Drawing.Size(541, 118);
            this.dgvEquivalencias.TabIndex = 8;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(145, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(270, 367);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(380, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Curso_Extranjero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CursoUPT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Creditos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nota Original";
            // 
            // txtCursoExtranjero
            // 
            this.txtCursoExtranjero.Location = new System.Drawing.Point(111, 144);
            this.txtCursoExtranjero.Name = "txtCursoExtranjero";
            this.txtCursoExtranjero.Size = new System.Drawing.Size(100, 20);
            this.txtCursoExtranjero.TabIndex = 7;
            // 
            // txtCursoUPT
            // 
            this.txtCursoUPT.Location = new System.Drawing.Point(111, 170);
            this.txtCursoUPT.Name = "txtCursoUPT";
            this.txtCursoUPT.Size = new System.Drawing.Size(100, 20);
            this.txtCursoUPT.TabIndex = 15;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(111, 196);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 20);
            this.txtCreditos.TabIndex = 16;
            // 
            // txtNotaOriginal
            // 
            this.txtNotaOriginal.Location = new System.Drawing.Point(391, 175);
            this.txtNotaOriginal.Name = "txtNotaOriginal";
            this.txtNotaOriginal.Size = new System.Drawing.Size(100, 20);
            this.txtNotaOriginal.TabIndex = 17;
            // 
            // lblTotalCreditos
            // 
            this.lblTotalCreditos.AutoSize = true;
            this.lblTotalCreditos.Location = new System.Drawing.Point(304, 200);
            this.lblTotalCreditos.Name = "lblTotalCreditos";
            this.lblTotalCreditos.Size = new System.Drawing.Size(41, 13);
            this.lblTotalCreditos.TabIndex = 20;
            this.lblTotalCreditos.Text = "label14";
            this.lblTotalCreditos.Click += new System.EventHandler(this.lblTotalCreditos_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(304, 227);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(61, 13);
            this.lblPromedio.TabIndex = 21;
            this.lblPromedio.Text = "lblPromedio";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(485, 367);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // FrmConvalidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalCreditos);
            this.Controls.Add(this.txtNotaOriginal);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtCursoUPT);
            this.Controls.Add(this.txtCursoExtranjero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEquivalencias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConvalidacion";
            this.Text = "FrmConvalidacion";
            this.Load += new System.EventHandler(this.FrmConvalidacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquivalencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvEquivalencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoExtranjero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoUPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaConvertida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCursoExtranjero;
        private System.Windows.Forms.TextBox txtCursoUPT;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNotaOriginal;
        private System.Windows.Forms.Label lblTotalCreditos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnNuevo;
    }
}