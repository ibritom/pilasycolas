using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    internal class Nodo
    {
        internal int valor { get; set; }
        internal int data { get; set; }
        internal Nodo? siguiente { get; set; }
        internal Nodo? anterior { get; set; }

        public Nodo(int valor)
        {
            this.valor = valor;
            this.data = data;
            this.siguiente = null;
            this.anterior = null;
        }
    }
}
