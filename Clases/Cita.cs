using System;

namespace Clases
{
    public class Cita
    {
        public Paciente Paciente { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

        public Cita(Paciente paciente, DateTime fechaHora, string motivo)
        {
            Paciente = paciente;
            FechaHora = fechaHora;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{FechaHora:yyyy-MM-dd HH:mm} - {Paciente.Nombre} - {Motivo}";
        }
    }
}
