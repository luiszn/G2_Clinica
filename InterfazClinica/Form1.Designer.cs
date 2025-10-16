namespace InterfazClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPacientesEnEspera = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.chkPrioritario = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AtenciónMédica = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbColaEspera = new System.Windows.Forms.GroupBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.dgvColaEspera = new System.Windows.Forms.DataGridView();
            this.gbAtencionActual = new System.Windows.Forms.GroupBox();
            this.btnFinalizarAtencion = new System.Windows.Forms.Button();
            this.btnLlamarSiguiente = new System.Windows.Forms.Button();
            this.lblPacienteActual = new System.Windows.Forms.Label();
            this.lblTituloPaciente = new System.Windows.Forms.Label();
            this.Pestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnEspera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.AtenciónMédica.SuspendLayout();
            this.gbColaEspera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaEspera)).BeginInit();
            this.gbAtencionActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tabPage1);
            this.Pestañas.Controls.Add(this.AtenciónMédica);
            this.Pestañas.Controls.Add(this.tabPage3);
            this.Pestañas.Controls.Add(this.tabPage4);
            this.Pestañas.Location = new System.Drawing.Point(0, 2);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(1038, 717);
            this.Pestañas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RegistroCliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPacientesEnEspera);
            this.groupBox2.Location = new System.Drawing.Point(10, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1013, 347);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-- PACIENTES EN ESPERA --";
            // 
            // dgvPacientesEnEspera
            // 
            this.dgvPacientesEnEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesEnEspera.Location = new System.Drawing.Point(7, 34);
            this.dgvPacientesEnEspera.Name = "dgvPacientesEnEspera";
            this.dgvPacientesEnEspera.RowHeadersWidth = 51;
            this.dgvPacientesEnEspera.RowTemplate.Height = 24;
            this.dgvPacientesEnEspera.Size = new System.Drawing.Size(1000, 307);
            this.dgvPacientesEnEspera.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numEdad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.chkPrioritario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 310);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-- DATOS DEL NUEVO PACIENTE --";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(200, 182);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 22);
            this.numEdad.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(200, 66);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(467, 163);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 54);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(472, 77);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 48);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // chkPrioritario
            // 
            this.chkPrioritario.AutoSize = true;
            this.chkPrioritario.Location = new System.Drawing.Point(89, 242);
            this.chkPrioritario.Name = "chkPrioritario";
            this.chkPrioritario.Size = new System.Drawing.Size(200, 20);
            this.chkPrioritario.TabIndex = 3;
            this.chkPrioritario.Text = "Paciente prioritario (Urgente)";
            this.chkPrioritario.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI :";
            // 
            // AtenciónMédica
            // 
            this.AtenciónMédica.Controls.Add(this.gbColaEspera);
            this.AtenciónMédica.Controls.Add(this.gbAtencionActual);
            this.AtenciónMédica.Location = new System.Drawing.Point(4, 25);
            this.AtenciónMédica.Name = "AtenciónMédica";
            this.AtenciónMédica.Padding = new System.Windows.Forms.Padding(3);
            this.AtenciónMédica.Size = new System.Drawing.Size(1030, 688);
            this.AtenciónMédica.TabIndex = 1;
            this.AtenciónMédica.Text = "AtencionMedica";
            this.AtenciónMédica.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1030, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HistorialAtencion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1030, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reportes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbColaEspera
            // 
            this.gbColaEspera.Controls.Add(this.btnVerDetalles);
            this.gbColaEspera.Controls.Add(this.btnActualizarLista);
            this.gbColaEspera.Controls.Add(this.dgvColaEspera);
            this.gbColaEspera.Location = new System.Drawing.Point(4, 382);
            this.gbColaEspera.Name = "gbColaEspera";
            this.gbColaEspera.Size = new System.Drawing.Size(1023, 295);
            this.gbColaEspera.TabIndex = 3;
            this.gbColaEspera.TabStop = false;
            this.gbColaEspera.Text = "--COLA DE ESPERA--";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(832, 174);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(151, 85);
            this.btnVerDetalles.TabIndex = 2;
            this.btnVerDetalles.Text = "VER DETALLES";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(832, 73);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(151, 84);
            this.btnActualizarLista.TabIndex = 1;
            this.btnActualizarLista.Text = "ACTUALIZAR LISTA";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            // 
            // dgvColaEspera
            // 
            this.dgvColaEspera.AllowUserToAddRows = false;
            this.dgvColaEspera.AllowUserToDeleteRows = false;
            this.dgvColaEspera.AllowUserToResizeColumns = false;
            this.dgvColaEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaEspera.Location = new System.Drawing.Point(6, 40);
            this.dgvColaEspera.Name = "dgvColaEspera";
            this.dgvColaEspera.ReadOnly = true;
            this.dgvColaEspera.RowHeadersWidth = 51;
            this.dgvColaEspera.RowTemplate.Height = 24;
            this.dgvColaEspera.Size = new System.Drawing.Size(786, 249);
            this.dgvColaEspera.TabIndex = 0;
            // 
            // gbAtencionActual
            // 
            this.gbAtencionActual.Controls.Add(this.btnFinalizarAtencion);
            this.gbAtencionActual.Controls.Add(this.btnLlamarSiguiente);
            this.gbAtencionActual.Controls.Add(this.lblPacienteActual);
            this.gbAtencionActual.Controls.Add(this.lblTituloPaciente);
            this.gbAtencionActual.Location = new System.Drawing.Point(5, 12);
            this.gbAtencionActual.Name = "gbAtencionActual";
            this.gbAtencionActual.Size = new System.Drawing.Size(1020, 364);
            this.gbAtencionActual.TabIndex = 2;
            this.gbAtencionActual.TabStop = false;
            this.gbAtencionActual.Text = "-- ATENCION ACTUAL-- ";
            // 
            // btnFinalizarAtencion
            // 
            this.btnFinalizarAtencion.Location = new System.Drawing.Point(531, 228);
            this.btnFinalizarAtencion.Name = "btnFinalizarAtencion";
            this.btnFinalizarAtencion.Size = new System.Drawing.Size(322, 79);
            this.btnFinalizarAtencion.TabIndex = 3;
            this.btnFinalizarAtencion.Text = "FINALIZAR ATENCIÓN ACTUAL";
            this.btnFinalizarAtencion.UseVisualStyleBackColor = true;
            // 
            // btnLlamarSiguiente
            // 
            this.btnLlamarSiguiente.Location = new System.Drawing.Point(80, 228);
            this.btnLlamarSiguiente.Name = "btnLlamarSiguiente";
            this.btnLlamarSiguiente.Size = new System.Drawing.Size(379, 79);
            this.btnLlamarSiguiente.TabIndex = 2;
            this.btnLlamarSiguiente.Text = "LLAMAR SIGUIENTE PACIENTE";
            this.btnLlamarSiguiente.UseVisualStyleBackColor = true;
            // 
            // lblPacienteActual
            // 
            this.lblPacienteActual.AutoSize = true;
            this.lblPacienteActual.Location = new System.Drawing.Point(374, 141);
            this.lblPacienteActual.Name = "lblPacienteActual";
            this.lblPacienteActual.Size = new System.Drawing.Size(192, 16);
            this.lblPacienteActual.TabIndex = 1;
            this.lblPacienteActual.Text = "\"Ningún paciente en atención\"  ";
            // 
            // lblTituloPaciente
            // 
            this.lblTituloPaciente.AutoSize = true;
            this.lblTituloPaciente.Location = new System.Drawing.Point(77, 67);
            this.lblTituloPaciente.Name = "lblTituloPaciente";
            this.lblTituloPaciente.Size = new System.Drawing.Size(175, 16);
            this.lblTituloPaciente.TabIndex = 0;
            this.lblTituloPaciente.Text = "PACIENTE EN CONSULTA:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 724);
            this.Controls.Add(this.Pestañas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnEspera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.AtenciónMédica.ResumeLayout(false);
            this.gbColaEspera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaEspera)).EndInit();
            this.gbAtencionActual.ResumeLayout(false);
            this.gbAtencionActual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage AtenciónMédica;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPacientesEnEspera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckBox chkPrioritario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox gbColaEspera;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.DataGridView dgvColaEspera;
        private System.Windows.Forms.GroupBox gbAtencionActual;
        private System.Windows.Forms.Button btnFinalizarAtencion;
        private System.Windows.Forms.Button btnLlamarSiguiente;
        private System.Windows.Forms.Label lblPacienteActual;
        private System.Windows.Forms.Label lblTituloPaciente;
    }
}

