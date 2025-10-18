using System;
using System.Collections.Generic;
using System.Linq;

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
                pacienteEnAtencion = null; 
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
        public int GetTotalPacientesAtendidos()
        {
            return historialCompleto.Count;
        }
        public int GetPacientesAtendidosPorEstado(string estado)
        {
            return historialCompleto.Count(h => h.Estado == estado);
        }
        public int GetPacientesUrgentesAtendidos()
        {
            return historialCompleto.Count(h => h.Paciente.Prioridad == 1);
        }
        public int GetPacientesNormalesAtendidos()
        {
            return historialCompleto.Count(h => h.Paciente.Prioridad == 0);
        }
        public List<HistorialAtencion> GetHistorialDelDia(DateTime fecha)
        {
            return historialCompleto.Where(h => h.FechaAtencion.Date == fecha.Date).ToList();
        }
        public TimeSpan GetTiempoPromedioAtencion()
        {
            if (historialCompleto.Count == 0)
                return TimeSpan.Zero;
            return TimeSpan.FromMinutes(20);
        }
        public Dictionary<string, int> GetEstadisticasCompletas()
        {
            return new Dictionary<string, int>
        {
            { "Total", GetTotalPacientesAtendidos() },
            { "Exitosos", GetPacientesAtendidosPorEstado("Exitoso") },
            { "Seguimiento", GetPacientesAtendidosPorEstado("Requiere seguimiento") },
            { "Derivados", GetPacientesAtendidosPorEstado("Derivado a especialista") },
            { "Hospitalizados", GetPacientesAtendidosPorEstado("Hospitalización") },
            { "Urgentes", GetPacientesUrgentesAtendidos() },
            { "Normales", GetPacientesNormalesAtendidos() }
        };
        }
    }
}