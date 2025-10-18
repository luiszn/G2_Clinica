using System;
using System.Collections.Generic;

namespace Clases
{
    public class GestorTurnos
    {
        private Cola colaPacientes;
        private Arbol arbolCitas;
        private List<HistorialAtencion> historialCompleto;
        private Paciente pacienteEnAtencion;

        public GestorTurnos()
        {
            colaPacientes = new Cola();
            arbolCitas = new Arbol();
            historialCompleto = new List<HistorialAtencion>();
            pacienteEnAtencion = null;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            colaPacientes.Encolar(paciente);
        }

        public Paciente AtenderPaciente()
        {
            return colaPacientes.Desencolar();
        }

        public void AgregarCita(Cita cita)
        {
            arbolCitas.Insertar(cita);
        }

        public List<Cita> ListarCitas()
        {
            return arbolCitas.InOrden();
        }

        public List<Paciente> ObtenerPacientesEnEspera()
        {
            return colaPacientes.ObtenerTodosLosPacientes();
        }

        public Paciente LlamarSiguientePaciente()
        {
            pacienteEnAtencion = colaPacientes.Desencolar();
            return pacienteEnAtencion;
        }

        public Paciente GetPacienteEnAtencion()
        {
            return pacienteEnAtencion;
        }

        public void FinalizarAtencionActual()
        {
            pacienteEnAtencion = null;
        }

        public bool HayPacientesEnEspera()
        {
            return colaPacientes.TienePacientes();
        }

        public void RegistrarHistorial(string diagnostico, string tratamiento, string estado, string comentarios)
        {
            if (pacienteEnAtencion != null)
            {
                var nuevoHistorial = new HistorialAtencion(pacienteEnAtencion, diagnostico, tratamiento, estado, comentarios);
                historialCompleto.Add(nuevoHistorial);
                pacienteEnAtencion = null; // Limpiar después de guardar
            }
        }

        public List<HistorialAtencion> GetHistorialCompleto()
        {
            return historialCompleto;
        }

        public Paciente GetPacienteParaHistorial()
        {
            return pacienteEnAtencion;
        }
    }
}