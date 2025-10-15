using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoArbol
    {
        public Cita Dato { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        public NodoArbol(Cita dato)
        {
            Dato = dato;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
