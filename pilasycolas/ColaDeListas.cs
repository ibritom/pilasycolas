using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    public class ColaDeListas
    {
        private Nodo delante;
        private Nodo detras;

        public ColaDeListas()
        {
            delante = null;
            detras = null;
        }

        public void AnadirCola(int element)
        {
            Nodo nuevoNodo = new Nodo(element);
            if (detras == null)
            {
                delante = nuevoNodo;
                detras = nuevoNodo;
            }
            else
            {
                detras.siguiente = nuevoNodo;
                detras = nuevoNodo;
            }
        }

        public int QuitarCola()
        {
            if (delante == null)
            {
                Console.WriteLine("Cola desfasada");
                return -1;
            }
            else
            {
                int element = delante.valor;
                delante = delante.siguiente;
                if (delante == null)
                {
                    detras = null;
                }
                return element;
            }
        }

        public int Delante()
        {
            if (delante == null)
            {
                Console.WriteLine("Cola desfasada");
                return -1;
            }
            else
            {
                return delante.valor;
            }
        }
    }

}
