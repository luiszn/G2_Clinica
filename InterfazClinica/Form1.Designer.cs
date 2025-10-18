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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabAtencion = new System.Windows.Forms.TabPage();
            this.gbColaEspera = new System.Windows.Forms.GroupBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.dgvColaEspera = new System.Windows.Forms.DataGridView();
            this.gbAtencionActual = new System.Windows.Forms.GroupBox();
            this.btnFinalizarAtencion = new System.Windows.Forms.Button();
            this.btnLlamarSiguiente = new System.Windows.Forms.Button();
            this.lblPacienteActual = new System.Windows.Forms.Label();
            this.lblTituloPaciente = new System.Windows.Forms.Label();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHistorialCompleto = new System.Windows.Forms.DataGridView();
            this.lblPacienteAtendido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarHistorial = new System.Windows.Forms.Button();
            this.btnGuardarHistorial = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.gbEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblTotalAtendidos = new System.Windows.Forms.Label();
            this.lblExitosos = new System.Windows.Forms.Label();
            this.lblSeguimiento = new System.Windows.Forms.Label();
            this.lblTiempoPromedio = new System.Windows.Forms.Label();
            this.lblDerivados = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.gbReporteDetallado = new System.Windows.Forms.GroupBox();
            this.txtReporteDetallado = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnEspera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.tabAtencion.SuspendLayout();
            this.gbColaEspera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaEspera)).BeginInit();
            this.gbAtencionActual.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompleto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.gbEstadisticas.SuspendLayout();
            this.gbReporteDetallado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabAtencion);
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Controls.Add(this.tabReportes);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 717);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabAtencion_Enter);
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
            // tabAtencion
            // 
            this.tabAtencion.Controls.Add(this.gbColaEspera);
            this.tabAtencion.Controls.Add(this.gbAtencionActual);
            this.tabAtencion.Location = new System.Drawing.Point(4, 25);
            this.tabAtencion.Name = "tabAtencion";
            this.tabAtencion.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtencion.Size = new System.Drawing.Size(1030, 688);
            this.tabAtencion.TabIndex = 1;
            this.tabAtencion.Text = "AtencionMedica";
            this.tabAtencion.UseVisualStyleBackColor = true;
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
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.groupBox4);
            this.tabHistorial.Controls.Add(this.lblPacienteAtendido);
            this.tabHistorial.Controls.Add(this.groupBox3);
            this.tabHistorial.Location = new System.Drawing.Point(4, 25);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(1030, 688);
            this.tabHistorial.TabIndex = 2;
            this.tabHistorial.Text = "HistorialAtencion";
            this.tabHistorial.UseVisualStyleBackColor = true;
            this.tabHistorial.Enter += new System.EventHandler(this.tabHistorial_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHistorialCompleto);
            this.groupBox4.Location = new System.Drawing.Point(4, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(997, 298);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HISTORIAL COMPLETO";
            // 
            // dgvHistorialCompleto
            // 
            this.dgvHistorialCompleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCompleto.Location = new System.Drawing.Point(30, 56);
            this.dgvHistorialCompleto.Name = "dgvHistorialCompleto";
            this.dgvHistorialCompleto.RowHeadersWidth = 51;
            this.dgvHistorialCompleto.RowTemplate.Height = 24;
            this.dgvHistorialCompleto.Size = new System.Drawing.Size(954, 227);
            this.dgvHistorialCompleto.TabIndex = 0;
            // 
            // lblPacienteAtendido
            // 
            this.lblPacienteAtendido.Location = new System.Drawing.Point(37, 17);
            this.lblPacienteAtendido.Name = "lblPacienteAtendido";
            this.lblPacienteAtendido.Size = new System.Drawing.Size(512, 30);
            this.lblPacienteAtendido.TabIndex = 5;
            this.lblPacienteAtendido.Text = "Paciente atendido: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiarHistorial);
            this.groupBox3.Controls.Add(this.btnGuardarHistorial);
            this.groupBox3.Controls.Add(this.txtTratamiento);
            this.groupBox3.Controls.Add(this.txtComentarios);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.lblComentarios);
            this.groupBox3.Controls.Add(this.lblEstado);
            this.groupBox3.Controls.Add(this.lblTratamiento);
            this.groupBox3.Controls.Add(this.txtDiagnostico);
            this.groupBox3.Controls.Add(this.lblDiagnostico);
            this.groupBox3.Location = new System.Drawing.Point(7, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1019, 300);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "REGISTRAR RESULTADO DE CONSULTA";
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(287, 249);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(203, 23);
            this.btnLimpiarHistorial.TabIndex = 10;
            this.btnLimpiarHistorial.Text = "LIMPIAR";
            this.btnLimpiarHistorial.UseVisualStyleBackColor = true;
            // 
            // btnGuardarHistorial
            // 
            this.btnGuardarHistorial.Location = new System.Drawing.Point(288, 209);
            this.btnGuardarHistorial.Name = "btnGuardarHistorial";
            this.btnGuardarHistorial.Size = new System.Drawing.Size(193, 23);
            this.btnGuardarHistorial.TabIndex = 9;
            this.btnGuardarHistorial.Text = "GUARDAR HISTORIAL";
            this.btnGuardarHistorial.UseVisualStyleBackColor = true;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(27, 139);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(436, 22);
            this.txtTratamiento.TabIndex = 8;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(33, 249);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(100, 22);
            this.txtComentarios.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(597, 123);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(30, 217);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(86, 16);
            this.lblComentarios.TabIndex = 5;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(594, 84);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(24, 110);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(82, 16);
            this.lblTratamiento.TabIndex = 3;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(27, 60);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(436, 22);
            this.txtDiagnostico.TabIndex = 2;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(24, 41);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(82, 16);
            this.lblDiagnostico.TabIndex = 1;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.gbReporteDetallado);
            this.tabReportes.Controls.Add(this.gbEstadisticas);
            this.tabReportes.Location = new System.Drawing.Point(4, 25);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(1030, 688);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // gbEstadisticas
            // 
            this.gbEstadisticas.Controls.Add(this.btnExportarPDF);
            this.gbEstadisticas.Controls.Add(this.btnGenerarReporte);
            this.gbEstadisticas.Controls.Add(this.lblDerivados);
            this.gbEstadisticas.Controls.Add(this.lblTiempoPromedio);
            this.gbEstadisticas.Controls.Add(this.lblSeguimiento);
            this.gbEstadisticas.Controls.Add(this.lblExitosos);
            this.gbEstadisticas.Controls.Add(this.lblTotalAtendidos);
            this.gbEstadisticas.Location = new System.Drawing.Point(5, 4);
            this.gbEstadisticas.Name = "gbEstadisticas";
            this.gbEstadisticas.Size = new System.Drawing.Size(1020, 397);
            this.gbEstadisticas.TabIndex = 0;
            this.gbEstadisticas.TabStop = false;
            this.gbEstadisticas.Text = "--ESTADISTICAS";
            // 
            // lblTotalAtendidos
            // 
            this.lblTotalAtendidos.AutoSize = true;
            this.lblTotalAtendidos.Location = new System.Drawing.Point(58, 54);
            this.lblTotalAtendidos.Name = "lblTotalAtendidos";
            this.lblTotalAtendidos.Size = new System.Drawing.Size(176, 16);
            this.lblTotalAtendidos.TabIndex = 0;
            this.lblTotalAtendidos.Text = "Total pacientes atendidos: 0";
            // 
            // lblExitosos
            // 
            this.lblExitosos.AutoSize = true;
            this.lblExitosos.Location = new System.Drawing.Point(70, 111);
            this.lblExitosos.Name = "lblExitosos";
            this.lblExitosos.Size = new System.Drawing.Size(137, 16);
            this.lblExitosos.TabIndex = 1;
            this.lblExitosos.Text = "Consultas exitosas: 0\"";
            // 
            // lblSeguimiento
            // 
            this.lblSeguimiento.AutoSize = true;
            this.lblSeguimiento.Location = new System.Drawing.Point(70, 174);
            this.lblSeguimiento.Name = "lblSeguimiento";
            this.lblSeguimiento.Size = new System.Drawing.Size(164, 16);
            this.lblSeguimiento.TabIndex = 2;
            this.lblSeguimiento.Text = "Requieren seguimiento: 0\"";
            // 
            // lblTiempoPromedio
            // 
            this.lblTiempoPromedio.AutoSize = true;
            this.lblTiempoPromedio.Location = new System.Drawing.Point(82, 275);
            this.lblTiempoPromedio.Name = "lblTiempoPromedio";
            this.lblTiempoPromedio.Size = new System.Drawing.Size(152, 16);
            this.lblTiempoPromedio.TabIndex = 3;
            this.lblTiempoPromedio.Text = "Tiempo promedio: 0 min";
            // 
            // lblDerivados
            // 
            this.lblDerivados.AutoSize = true;
            this.lblDerivados.Location = new System.Drawing.Point(70, 224);
            this.lblDerivados.Name = "lblDerivados";
            this.lblDerivados.Size = new System.Drawing.Size(83, 16);
            this.lblDerivados.TabIndex = 4;
            this.lblDerivados.Text = "Derivados: 0";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(413, 54);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(209, 96);
            this.btnGenerarReporte.TabIndex = 5;
            this.btnGenerarReporte.Text = "GENERAR REPORTE DIARIO";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(413, 204);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(225, 121);
            this.btnExportarPDF.TabIndex = 6;
            this.btnExportarPDF.Text = "EXPORTAR A PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            // 
            // gbReporteDetallado
            // 
            this.gbReporteDetallado.Controls.Add(this.txtReporteDetallado);
            this.gbReporteDetallado.Location = new System.Drawing.Point(4, 408);
            this.gbReporteDetallado.Name = "gbReporteDetallado";
            this.gbReporteDetallado.Size = new System.Drawing.Size(1020, 274);
            this.gbReporteDetallado.TabIndex = 1;
            this.gbReporteDetallado.TabStop = false;
            this.gbReporteDetallado.Text = "--REPORTE DETALLADO--";
            // 
            // txtReporteDetallado
            // 
            this.txtReporteDetallado.Location = new System.Drawing.Point(38, 39);
            this.txtReporteDetallado.Multiline = true;
            this.txtReporteDetallado.Name = "txtReporteDetallado";
            this.txtReporteDetallado.ReadOnly = true;
            this.txtReporteDetallado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporteDetallado.Size = new System.Drawing.Size(894, 196);
            this.txtReporteDetallado.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 724);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEnEspera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.tabAtencion.ResumeLayout(false);
            this.gbColaEspera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaEspera)).EndInit();
            this.gbAtencionActual.ResumeLayout(false);
            this.gbAtencionActual.PerformLayout();
            this.tabHistorial.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompleto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.gbEstadisticas.ResumeLayout(false);
            this.gbEstadisticas.PerformLayout();
            this.gbReporteDetallado.ResumeLayout(false);
            this.gbReporteDetallado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabAtencion;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabReportes;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHistorialCompleto;
        private System.Windows.Forms.Label lblPacienteAtendido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiarHistorial;
        private System.Windows.Forms.Button btnGuardarHistorial;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.GroupBox gbEstadisticas;
        private System.Windows.Forms.GroupBox gbReporteDetallado;
        private System.Windows.Forms.TextBox txtReporteDetallado;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblDerivados;
        private System.Windows.Forms.Label lblTiempoPromedio;
        private System.Windows.Forms.Label lblSeguimiento;
        private System.Windows.Forms.Label lblExitosos;
        private System.Windows.Forms.Label lblTotalAtendidos;
    }
}

