using Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfazClinica
{
    public partial class Form1 : Form
    {
        private GestorTurnos gestor;
        private bool estaProcesando = false;
        public Form1()
        {
            InitializeComponent();

            gestor = new GestorTurnos();
            ConfigurarEventosPestaña1();
            ConfigurarPestaña2();
            ConfigurarPestaña3();
            ConfigurarPestaña4();
        }
        private void ConfigurarEventosPestaña1()
        {
            btnRegistrar.Click += btnRegistrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            ConfigurarDataGridView();

            txtDni.TextChanged += ValidarFormulario;
            txtNombre.TextChanged += ValidarFormulario;
            numEdad.ValueChanged += ValidarFormulario;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string dni = txtDni.Text;
            string nombre = txtNombre.Text;

            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos");
                return;
            }

            var pacientes = gestor.ObtenerPacientesEnEspera();

            if (pacientes.Any(p => p.Dni == dni))
            {
                MessageBox.Show("Ya existe un paciente con este DNI");
                return;
            }
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("DNI o Nombre están vacíos");
                return;
            }

            int edad = (int)numEdad.Value;
            int prioridad = chkPrioritario.Checked ? 1 : 0;

            Paciente nuevoPaciente = new Paciente(dni, nombre, edad, prioridad);
            gestor.AgregarPaciente(nuevoPaciente);
            ActualizarListaPacientesEnEspera();

            MessageBox.Show($"Paciente {nombre} registrado EXITOSAMENTE");
            LimpiarFormulario();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            txtDni.Clear();
            txtNombre.Clear();
            numEdad.Value = 0;
            chkPrioritario.Checked = false;

            txtDni.Focus();
        }
        private void ValidarFormulario(object sender, EventArgs e)
        {
            bool formularioValido = !string.IsNullOrWhiteSpace(txtDni.Text) &&
                                   !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                   numEdad.Value > 0;

            btnRegistrar.Enabled = formularioValido;

            if (formularioValido)
            {
                btnRegistrar.BackColor = Color.LightGreen;
                btnRegistrar.Text = "REGISTRAR PACIENTE ✓";
            }
            else
            {
                btnRegistrar.BackColor = Color.LightGray;
                btnRegistrar.Text = "REGISTRAR PACIENTE";
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvPacientesEnEspera.Columns.Clear();

            dgvPacientesEnEspera.Columns.Add("Dni", "DNI");
            dgvPacientesEnEspera.Columns.Add("Nombre", "Nombre");
            dgvPacientesEnEspera.Columns.Add("Edad", "Edad");
            dgvPacientesEnEspera.Columns.Add("Prioridad", "Prioridad");

            dgvPacientesEnEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientesEnEspera.ReadOnly = true;
            dgvPacientesEnEspera.RowHeadersVisible = false;
        }
        private void ActualizarListaPacientesEnEspera()
        {
            try
            {
                dgvPacientesEnEspera.Rows.Clear();

                var pacientes = gestor.ObtenerPacientesEnEspera();

                foreach (var paciente in pacientes)
                {
                    string prioridadTexto = paciente.Prioridad == 1 ? "URGENTE" : "Normal";
                    dgvPacientesEnEspera.Rows.Add(
                        paciente.Dni,
                        paciente.Nombre,
                        paciente.Edad,
                        prioridadTexto
                    );

                    // Colorear filas según prioridad
                    int lastIndex = dgvPacientesEnEspera.Rows.Count - 1;
                    if (paciente.Prioridad == 1)
                    {
                        dgvPacientesEnEspera.Rows[lastIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvPacientesEnEspera.Rows[lastIndex].DefaultCellStyle.Font =
                            new Font(dgvPacientesEnEspera.Font, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar lista: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarPestaña2()
        {
            // Conectar eventos de la pestaña 2 - SOLO EN CÓDIGO
            btnLlamarSiguiente.Click += btnLlamarSiguiente_Click;
            btnFinalizarAtencion.Click += btnFinalizarAtencion_Click;
            btnActualizarLista.Click += btnActualizarLista_Click;
            btnVerDetalles.Click += btnVerDetalles_Click;
            tabAtencion.Enter += tabAtencion_Enter;
            // Configurar DataGridView de la cola de espera
            ConfigurarDataGridViewColaEspera();

            // Actualizar interfaz inicial
            ActualizarInterfazAtencion();
        }

        private void btnLlamarSiguiente_Click(object sender, EventArgs e)
        {
            if (estaProcesando) return;
            estaProcesando = true;

            try
            {
                if (gestor.HayPacientesEnEspera())
                {
                    Paciente siguientePaciente = gestor.LlamarSiguientePaciente();

                    if (siguientePaciente != null)
                    {
                        // Mostrar paciente en consulta
                        string prioridadTexto = siguientePaciente.Prioridad == 1 ? "URGENTE" : "Normal";
                        lblPacienteActual.Text = $"{siguientePaciente.Nombre} ({siguientePaciente.Edad} años) - {prioridadTexto}";

                        MessageBox.Show($"🔔 Llamando a: {siguientePaciente.Nombre}", "Atención",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarColaEspera();
                    }
                }
                else
                {
                    MessageBox.Show("No hay pacientes en espera", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                estaProcesando = false;
            }
        }

        private void btnFinalizarAtencion_Click(object sender, EventArgs e)
        {
            if (gestor.GetPacienteEnAtencion() != null)
            {
                var paciente = gestor.GetPacienteEnAtencion();

                DialogResult result = MessageBox.Show(
                    $"¿Finalizar atención de {paciente.Nombre} y enviar a historial?",
                    "Finalizar Atención",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // ❌ QUITA ESTA LÍNEA - Está borrando el paciente
                    // gestor.FinalizarAtencionActual(); 

                    lblPacienteActual.Text = "Ningún paciente en atención";
                    MessageBox.Show($"Paciente {paciente.Nombre} listo para registrar en historial", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ir automáticamente a pestaña 3
                    tabControl1.SelectedTab = tabHistorial;
                }
            }
            else
            {
                MessageBox.Show("No hay paciente en atención actualmente", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            ActualizarColaEspera();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvColaEspera.CurrentRow != null && dgvColaEspera.CurrentRow.Cells["Dni"].Value != null)
            {
                string dni = dgvColaEspera.CurrentRow.Cells["Dni"].Value.ToString();
                var pacientes = gestor.ObtenerPacientesEnEspera();
                var paciente = pacientes.FirstOrDefault(p => p.Dni == dni);

                if (paciente != null)
                {
                    string prioridad = paciente.Prioridad == 1 ? "URGENTE" : "Normal";
                    string mensaje = $"DNI: {paciente.Dni}\n" +
                                   $"Nombre: {paciente.Nombre}\n" +
                                   $"Edad: {paciente.Edad} años\n" +
                                   $"Prioridad: {prioridad}";

                    MessageBox.Show(mensaje, "Detalles del Paciente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ConfigurarDataGridViewColaEspera()
        {
            dgvColaEspera.Columns.Clear();

            dgvColaEspera.Columns.Add("Dni", "DNI");
            dgvColaEspera.Columns.Add("Nombre", "Nombre");
            dgvColaEspera.Columns.Add("Edad", "Edad");
            dgvColaEspera.Columns.Add("Prioridad", "Prioridad");
            dgvColaEspera.Columns.Add("Tiempo", "Tiempo Espera");

            dgvColaEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColaEspera.ReadOnly = true;
            dgvColaEspera.RowHeadersVisible = false;
        }

        private void ActualizarColaEspera()
        {
            try
            {
                dgvColaEspera.Rows.Clear();
                var pacientes = gestor.ObtenerPacientesEnEspera();

                int orden = 1;
                foreach (var paciente in pacientes)
                {
                    string prioridadTexto = paciente.Prioridad == 1 ? "URGENTE" : "Normal";
                    string tiempoEstimado = CalcularTiempoEspera(orden, paciente.Prioridad);

                    int rowIndex = dgvColaEspera.Rows.Add(
                        paciente.Dni,
                        paciente.Nombre,
                        paciente.Edad,
                        prioridadTexto,
                        tiempoEstimado
                    );

                    if (paciente.Prioridad == 1)
                    {
                        dgvColaEspera.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvColaEspera.Rows[rowIndex].DefaultCellStyle.Font =
                            new Font(dgvColaEspera.Font, FontStyle.Bold);
                    }
                    else if (orden == 1)
                    {
                        dgvColaEspera.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgvColaEspera.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }

                    orden++;
                }
                if (pacientes.Count == 0)
                {
                    dgvColaEspera.Rows.Add("", "No hay pacientes en espera", "", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cola: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalcularTiempoEspera(int orden, int prioridad)
        {
            int tiempoBase = orden * 15;

            if (prioridad == 1)
            {
                tiempoBase = Math.Max(5, (orden - 1) * 10);
            }

            return $"{tiempoBase} min";
        }

        private void ActualizarInterfazAtencion()
        {
            // Actualizar paciente actual
            var pacienteActual = gestor.GetPacienteEnAtencion();
            if (pacienteActual != null)
            {
                string prioridadTexto = pacienteActual.Prioridad == 1 ? "URGENTE" : "Normal";
                lblPacienteActual.Text = $"{pacienteActual.Nombre} ({pacienteActual.Edad} años) - {prioridadTexto}";
            }
            else
            {
                lblPacienteActual.Text = "Ningún paciente en atención";
            }

            // Actualizar cola de espera
            ActualizarColaEspera();
        }

        private void tabAtencion_Enter(object sender, EventArgs e)
        {
            ActualizarInterfazAtencion();
        }
        private void ConfigurarPestaña3()
        {
            btnGuardarHistorial.Click += btnGuardarHistorial_Click;
            btnLimpiarHistorial.Click += btnLimpiarHistorial_Click;

            tabHistorial.Enter += tabHistorial_Enter;

            ConfigurarComboBoxEstados();

            ConfigurarDataGridViewHistorial();

            ActualizarInterfazHistorial();
        }
        private void ConfigurarComboBoxEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] {
        "Exitoso", "Requiere seguimiento", "Derivado a especialista", "Hospitalización"
    });
            cmbEstado.SelectedIndex = 0;
        }
        private void ConfigurarDataGridViewHistorial()
        {
            dgvHistorialCompleto.Columns.Clear();
            dgvHistorialCompleto.Columns.Add("Fecha", "Fecha");
            dgvHistorialCompleto.Columns.Add("Paciente", "Paciente");
            dgvHistorialCompleto.Columns.Add("Diagnostico", "Diagnóstico");
            dgvHistorialCompleto.Columns.Add("Estado", "Estado");

            dgvHistorialCompleto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCompleto.ReadOnly = true;
            dgvHistorialCompleto.RowHeadersVisible = false;

            dgvHistorialCompleto.CellClick += dgvHistorialCompleto_CellClick;
        }
        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            if (estaProcesando) return;
            estaProcesando = true;

            try
            {
                var paciente = gestor.GetPacienteParaHistorial();
                if (paciente == null)
                {
                    MessageBox.Show("No hay paciente en atención para guardar historial", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
                {
                    MessageBox.Show("El diagnóstico es obligatorio", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiagnostico.Focus();
                    return;
                }

                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un estado", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEstado.Focus();
                    return;
                }

                string diagnostico = txtDiagnostico.Text.Trim();
                string tratamiento = txtTratamiento.Text.Trim();
                string estado = cmbEstado.SelectedItem.ToString();
                string comentarios = txtComentarios.Text.Trim();

                gestor.RegistrarHistorial(diagnostico, tratamiento, estado, comentarios);

                MessageBox.Show($"Historial de {paciente.Nombre} guardado exitosamente", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarListaHistorialCompleto();
                LimpiarFormularioHistorial();
                ActualizarInterfazHistorial();
            }
            finally
            {
                estaProcesando = false;
            }
        }
        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            LimpiarFormularioHistorial();
        }

        private void LimpiarFormularioHistorial()
        {
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            cmbEstado.SelectedIndex = 0;
            txtComentarios.Clear();
            txtDiagnostico.Focus();
        }
        private void ActualizarListaHistorialCompleto()
        {
            try
            {
                dgvHistorialCompleto.Rows.Clear();
                var historial = gestor.GetHistorialCompleto();

                foreach (var registro in historial)
                {
                    int rowIndex = dgvHistorialCompleto.Rows.Add(
                        registro.FechaAtencion.ToString("HH:mm"),
                        registro.Paciente.Nombre,
                        ObtenerResumen(registro.Diagnostico, 20),
                        registro.Estado
                    );

                    switch (registro.Estado)
                    {
                        case "Exitoso":
                            dgvHistorialCompleto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Requiere seguimiento":
                            dgvHistorialCompleto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Derivado a especialista":
                            dgvHistorialCompleto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Hospitalización":
                            dgvHistorialCompleto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                    }
                }

                if (historial.Count == 0)
                {
                    dgvHistorialCompleto.Rows.Add("", "No hay historial registrado", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar historial: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ObtenerResumen(string texto, int maxLength)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            return texto.Length <= maxLength ? texto : texto.Substring(0, maxLength) + "...";
        }

        private void ActualizarInterfazHistorial()
        {
            var paciente = gestor.GetPacienteParaHistorial();
            if (paciente != null)
            {
                string prioridadTexto = paciente.Prioridad == 1 ? "URGENTE" : "Normal";
                lblPacienteAtendido.Text = $"Paciente atendido: {paciente.Nombre} ({paciente.Edad} años) - {prioridadTexto}";
                lblPacienteAtendido.ForeColor = Color.DarkGreen;
                lblPacienteAtendido.Font = new Font(lblPacienteAtendido.Font, FontStyle.Bold);
            }
            else
            {
                lblPacienteAtendido.Text = "Paciente atendido: Ningún paciente en espera de historial";
                lblPacienteAtendido.ForeColor = Color.Gray;
                lblPacienteAtendido.Font = new Font(lblPacienteAtendido.Font, FontStyle.Regular);
            }
            ActualizarListaHistorialCompleto();
        }
        private void tabHistorial_Enter(object sender, EventArgs e)
        {
            ActualizarInterfazHistorial();
        }
        private void dgvHistorialCompleto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHistorialCompleto.Rows[e.RowIndex].Cells["Paciente"].Value != null)
            {
                string nombrePaciente = dgvHistorialCompleto.Rows[e.RowIndex].Cells["Paciente"].Value.ToString();
                var historial = gestor.GetHistorialCompleto();
                var registro = historial.FirstOrDefault(h => h.Paciente.Nombre == nombrePaciente);

                if (registro != null)
                {
                    string mensaje = $" DETALLES COMPLETOS DE LA CONSULTA\n\n" +
                                   $" Paciente: {registro.Paciente.Nombre}\n" +
                                   $" DNI: {registro.Paciente.Dni}\n" +
                                   $" Edad: {registro.Paciente.Edad} años\n" +
                                   $" Fecha: {registro.FechaAtencion:dd/MM/yyyy HH:mm}\n\n" +
                                   $" DIAGNÓSTICO:\n{registro.Diagnostico}\n\n" +
                                   $" TRATAMIENTO:\n{registro.Tratamiento}\n\n" +
                                   $" ESTADO: {registro.Estado}\n\n" +
                                   $" COMENTARIOS:\n{registro.Comentarios}";

                    MessageBox.Show(mensaje, "Detalles Completo de Consulta",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ConfigurarPestaña4()
        {
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            btnExportarPDF.Click += btnExportarPDF_Click;
            tabReportes.Enter += tabReportes_Enter;
            GenerarReporteDelDia();
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteDelDia();
        }
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string reporte = txtReporteDetallado.Text;
                if (string.IsNullOrWhiteSpace(reporte) || reporte.Contains("No hay registros"))
                {
                    MessageBox.Show("❌ No hay datos en el reporte\n\nGenere el reporte primero con pacientes atendidos",
                                  "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Archivo txt (*.txt)|*.txt";
                    saveDialog.FileName = $"Reporte_Clinico_{DateTime.Today:yyyyMMdd}_{DateTime.Now:HHmm}";
                    saveDialog.Title = "Guardar Reporte Clínico";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = saveDialog.FileName;

                        string contenido = $"REPORTE CLÍNICO - SISTEMA DE GESTIÓN\n" +
                                         $"===========================================\n" +
                                         $"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                                         $"Archivo: {Path.GetFileName(rutaArchivo)}\n" +
                                         $"===========================================\n\n" +
                                         $"{reporte}";

                        File.WriteAllText(rutaArchivo, contenido, Encoding.UTF8);

                        MostrarMensajeExito(rutaArchivo, reporte);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarMensajeExito(string rutaArchivo, string reporte)
        {
            int totalPacientes = reporte.Split('\n').Count(line => line.Contains("•") && line.Contains("-"));
            int totalLineas = reporte.Split('\n').Length;

            string mensaje = $"📄 **REPORTE EXPORTADO EXITOSAMENTE**\n\n" +
                            $"📍 **Ubicación:** {rutaArchivo}\n" +
                            $"📊 **Pacientes en reporte:** {totalPacientes}\n" +
                            $"📏 **Páginas estimadas:** {Math.Max(1, totalLineas / 40)}\n" +
                            $"💾 **Tamaño del archivo:** {(reporte.Length / 1024.0):0.0} KB\n\n" +
                            $"✅ El archivo  está listo para usar";

            MessageBox.Show(mensaje, "✅ Exportación Completada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GenerarReporteDelDia()
        {
            try
            {
                var estadisticas = gestor.GetEstadisticasCompletas();
                int totalAtendidos = estadisticas["Total"];
                int exitosos = estadisticas["Exitosos"];
                int seguimiento = estadisticas["Seguimiento"];
                int derivados = estadisticas["Derivados"];
                int hospitalizados = estadisticas["Hospitalizados"];
                int urgentes = estadisticas["Urgentes"];
                int normales = estadisticas["Normales"];
                TimeSpan tiempoPromedio = gestor.GetTiempoPromedioAtencion();

                double porcentajeExitosos = totalAtendidos > 0 ? (exitosos * 100.0) / totalAtendidos : 0;
                double porcentajeUrgentes = totalAtendidos > 0 ? (urgentes * 100.0) / totalAtendidos : 0;

                
                lblTotalAtendidos.Text = $"📈 Total pacientes atendidos: {totalAtendidos}";
                lblExitosos.Text = $"✅ Consultas exitosas: {exitosos} ({porcentajeExitosos:0.0}%)";
                lblSeguimiento.Text = $"🔄 Requieren seguimiento: {seguimiento}";
                lblDerivados.Text = $"🏥 Derivados: {derivados}";
                lblTiempoPromedio.Text = $"⏱️ Tiempo promedio: {tiempoPromedio.TotalMinutes:0} min";

                
                ColorearEstadisticas(totalAtendidos, porcentajeExitosos);

                
                GenerarReporteDetallado(estadisticas, tiempoPromedio);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorearEstadisticas(int totalAtendidos, double porcentajeExitosos)
        {
            
            lblTotalAtendidos.BackColor = totalAtendidos > 0 ? Color.LightGreen : Color.LightGray;
            lblExitosos.BackColor = porcentajeExitosos >= 70 ? Color.LightGreen : Color.LightYellow;
        }

        private void GenerarReporteDetallado(Dictionary<string, int> estadisticas, TimeSpan tiempoPromedio)
        {
            StringBuilder reporte = new StringBuilder();

            int totalAtendidos = estadisticas["Total"];
            int exitosos = estadisticas["Exitosos"];
            int seguimiento = estadisticas["Seguimiento"];
            int derivados = estadisticas["Derivados"];
            int hospitalizados = estadisticas["Hospitalizados"];
            int urgentes = estadisticas["Urgentes"];
            int normales = estadisticas["Normales"];

            reporte.AppendLine($"📊 REPORTE CLÍNICO - {DateTime.Today:dd/MM/yyyy}");
            reporte.AppendLine("===========================================");
            reporte.AppendLine();

            reporte.AppendLine("📈 ESTADÍSTICAS GENERALES:");
            reporte.AppendLine($"   • Total pacientes atendidos: {totalAtendidos}");
            reporte.AppendLine($"   • Tiempo promedio de atención: {tiempoPromedio.TotalMinutes:0} minutos");
            reporte.AppendLine();

            reporte.AppendLine("🎯 DISTRIBUCIÓN POR PRIORIDAD:");
            reporte.AppendLine($"   • Pacientes urgentes: {urgentes}");
            reporte.AppendLine($"   • Pacientes normales: {normales}");
            reporte.AppendLine();

            reporte.AppendLine("🏥 RESULTADOS DE ATENCIÓN:");
            reporte.AppendLine($"   • ✅ Exitosa: {exitosos}");
            reporte.AppendLine($"   • 🔄 Requiere seguimiento: {seguimiento}");
            reporte.AppendLine($"   • 👨‍⚕️ Derivados a especialista: {derivados}");
            reporte.AppendLine($"   • 🏥 Hospitalizados: {hospitalizados}");
            reporte.AppendLine();

            if (totalAtendidos > 0)
            {
                reporte.AppendLine("📋 PORCENTAJES:");
                reporte.AppendLine($"   • Tasa de éxito: {(exitosos * 100.0 / totalAtendidos):0.0}%");
                reporte.AppendLine($"   • Pacientes urgentes: {(urgentes * 100.0 / totalAtendidos):0.0}%");
                reporte.AppendLine($"   • Necesitan seguimiento: {(seguimiento * 100.0 / totalAtendidos):0.0}%");
                reporte.AppendLine();
            }

            reporte.AppendLine("📝 DETALLE POR PACIENTE:");
            reporte.AppendLine("-------------------------------------------");

            var historialDelDia = gestor.GetHistorialDelDia(DateTime.Today);
            if (historialDelDia.Count > 0)
            {
                foreach (var registro in historialDelDia)
                {
                    string prioridad = registro.Paciente.Prioridad == 1 ? "URGENTE" : "Normal";
                    string resumenDiagnostico = registro.Diagnostico.Length > 30 ?
                        registro.Diagnostico.Substring(0, 30) + "..." : registro.Diagnostico;

                    reporte.AppendLine($"   • {registro.FechaAtencion:HH:mm} - {registro.Paciente.Nombre}");
                    reporte.AppendLine($"     {registro.Estado} | {prioridad} | {resumenDiagnostico}");
                    reporte.AppendLine();
                }
            }
            else
            {
                reporte.AppendLine("   No hay registros para el día de hoy");
                reporte.AppendLine();
            }

            reporte.AppendLine("===========================================");
            reporte.AppendLine($"📋 Reporte generado: {DateTime.Now:dd/MM/yyyy HH:mm}");

            
            txtReporteDetallado.Text = reporte.ToString();
        }

        private void tabReportes_Enter(object sender, EventArgs e)
        {
            GenerarReporteDelDia();
        }
    }
}
