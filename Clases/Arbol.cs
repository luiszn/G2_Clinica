using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        private NodoArbol raiz;

        public Arbol()
        {
            raiz = null;
        }

        public void Insertar(Cita cita)
        {
            raiz = InsertarRec(raiz, cita);
        }

        private NodoArbol InsertarRec(NodoArbol actual, Cita cita)
        {
            if (actual == null)
                return new NodoArbol(cita);

            if (cita.FechaHora < actual.Dato.FechaHora)
                actual.Izquierdo = InsertarRec(actual.Izquierdo, cita);
            else
                actual.Derecho = InsertarRec(actual.Derecho, cita);

            return actual;
        }

        public List<Cita> InOrden()
        {
            var lista = new List<Cita>();
            InOrdenRec(raiz, lista);
            return lista;
        }

        private void InOrdenRec(NodoArbol actual, List<Cita> lista)
        {
            if (actual == null) return;
            InOrdenRec(actual.Izquierdo, lista);
            lista.Add(actual.Dato);
            InOrdenRec(actual.Derecho, lista);
        }
    }
}
