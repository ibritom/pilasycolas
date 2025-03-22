﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasycolas
{
    public class ColaDeArreglos : Cola
    {
        private int[] cola;
        private int delante;
        private int destras;
        private int tamano;

        public ColaDeArreglos(int tamano)
        {
            this.tamano = tamano;
            cola = new int[tamano];
            delante = -1;
            destras = -1;
        }

        public void AnadirACola(int elemento)
        {
            if (destras == tamano - 1)
            {
                Console.WriteLine("Desbordamiento de la cola");
            }
            else
            {
                if (delante == -1)
                {
                    delante = 0;
                }
                cola[++destras] = elemento;
            }
        }

        public int QuitarDeCola()
        {
            if (delante == -1)
            {
                Console.WriteLine("Desfase de cola");
                return -1;
            }
            else
            {
                int elemento = cola[delante];
                if (delante == destras)
                {
                    delante = -1;
                    destras = -1;
                }
                else
                {
                    delante++;
                }
                return elemento;
            }
        }

        public int Delante()
        {
            if (delante == -1)
            {
                Console.WriteLine("Lista desfasada");
                return -1;
            }
            else
            {
                return cola[delante];
            }
        }
    }

}
