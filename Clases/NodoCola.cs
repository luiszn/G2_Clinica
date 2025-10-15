using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoCola
    {
        public Paciente Dato { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Paciente dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
