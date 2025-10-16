using System;
using System.Collections.Generic;

namespace Clases
{
    public class GestorTurnos
    {
        private Cola colaPacientes;
        private Arbol arbolCitas;

        public GestorTurnos()
        {
            colaPacientes = new Cola();
            arbolCitas = new Arbol();
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
    }
}
