using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    internal class PilaListas : Pila
    {
        private Nodo cima;
        public void Push(int elemento)
        {
            Nodo nuevoNodo = new Nodo(elemento);
            nuevoNodo.siguiente = cima;
            cima = nuevoNodo;
        }
        public int Pop()
        {
            if (cima == null)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            } else {
                int elemento = cima.data;
                cima = cima.siguiente;
                return elemento;
            }
        }
        public int Top()
        {
            if (cima == null) {
                Console.WriteLine("Stack Underflow");
                return -1;
            } else {
                return cima.data;
            }
        }
    }
}
