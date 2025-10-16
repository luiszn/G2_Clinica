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
        public Form1()
        {
            InitializeComponent();

            gestor = new GestorTurnos();
            ConfigurarEventosPestaña1();
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
    }
}
