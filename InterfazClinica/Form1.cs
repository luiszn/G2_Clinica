using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // ========== PESTAÑA 2: ATENCIÓN MÉDICA ==========
        private void ConfigurarPestaña2()
        {
            // Conectar eventos de la pestaña 2 - SOLO EN CÓDIGO
            btnLlamarSiguiente.Click += btnLlamarSiguiente_Click;
            btnFinalizarAtencion.Click += btnFinalizarAtencion_Click;
            btnActualizarLista.Click += btnActualizarLista_Click;
            btnVerDetalles.Click += btnVerDetalles_Click;

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
                    $"¿Finalizar atención de {paciente.Nombre}?",
                    "Finalizar Atención",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    gestor.FinalizarAtencionActual();
                    lblPacienteActual.Text = "Ningún paciente en atención";
                    MessageBox.Show("Atención finalizada", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
