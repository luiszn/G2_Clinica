using System;
using System.Collections.Generic;

namespace Clases
{
    public class Cola
    {
        private NodoCola frente;
        private NodoCola fin;

        public Cola()
        {
            frente = null;
            fin = null;
        }

        public void Encolar(Paciente p)
        {
            var nuevo = new NodoCola(p);
            if (frente == null)
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                if (p.Prioridad == 0)
                {
                    fin.Siguiente = nuevo;
                    fin = nuevo;
                }
                else
                {
                    if (frente.Dato.Prioridad == 0)
                    {
                        nuevo.Siguiente = frente;
                        frente = nuevo;
                    }
                    else
                    {
                        NodoCola temp = frente;
                        while (temp.Siguiente != null && temp.Siguiente.Dato.Prioridad == 1)
                        {
                            temp = temp.Siguiente;
                        }
                        nuevo.Siguiente = temp.Siguiente;
                        temp.Siguiente = nuevo;
                        if (nuevo.Siguiente == null)
                            fin = nuevo;
                    }
                }
            }
        }

        public Paciente Desencolar()
        {
            if (frente == null) return null;
            Paciente p = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null) fin = null;
            return p;
        }
        public List<Paciente> ObtenerTodosLosPacientes()
        {
            var lista = new List<Paciente>();
            var actual = frente;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }
        public bool TienePacientes()
        {
            return frente != null;
        }
    }
}
