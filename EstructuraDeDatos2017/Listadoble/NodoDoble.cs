using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos2017.Listadoble
{
    public  class NodoDoble
    {
        int d;
        NodoDoble izquierda;
        NodoDoble derecha;
        public NodoDoble(int dato)
        {
            
            izquierda = null;
            d = dato;
            derecha = null;
        }
        public NodoDoble Izquierda
        {
            set { izquierda = value; }
            get { return izquierda; }
        }
        public NodoDoble Derecha
        {
            set { derecha = value; }
            get { return derecha; }
        }
        public int dato
        {
            set { d = value; }
            get { return d; }
        } 

    }
}
