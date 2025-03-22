﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    internal class PilaArreglos : Pila
    {
        private int[]? pila;
        private int cima;
        private int tamano;

        public PilaArreglos(int tamano)
        {
            this.tamano = tamano;
            pila = new int[tamano];
            cima = -1;
        }
        public void Push(int elemento)
        {
            if ( cima == tamano -1 )
            {
                Console.WriteLine("Stack Overflow");
            } else
            {
                pila[++cima] = elemento;
            }
        }
        public int Pop()
        {
            if (cima == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            } else {
                return pila[cima--];
            }
        }
        public int Top()
        {
            if (cima == -1) {
                Console.WriteLine("Stack Underflow");
                return -1;
            } else
            {
                return pila[cima];
            }
        }

    }
}
