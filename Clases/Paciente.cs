using System;

namespace Clases
{
    public class Paciente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Prioridad { get; set; } // 0 = normal, 1 = prioritario

        public Paciente(string dni, string nombre, int edad, int prioridad)
        {
            Dni = dni;
            Nombre = nombre;
            Edad = edad;
            Prioridad = prioridad;
        }

        public override string ToString()
        {
            return $"{Nombre} (DNI: {Dni}) - Edad: {Edad} - Prioridad: {Prioridad}";
        }
    }
}
