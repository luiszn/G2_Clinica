using System;

namespace Clases
{
    public class HistorialAtencion
    {
        public Paciente Paciente { get; set; }
        public DateTime FechaAtencion { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }

        public HistorialAtencion(Paciente paciente, string diagnostico, string tratamiento, string estado, string comentarios)
        {
            Paciente = paciente;
            FechaAtencion = DateTime.Now;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Estado = estado;
            Comentarios = comentarios;
        }

        public override string ToString()
        {
            return $"{FechaAtencion:HH:mm} - {Paciente.Nombre} - {Diagnostico} - {Estado}";
        }
    }
}
