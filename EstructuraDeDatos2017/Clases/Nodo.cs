using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos2017.Clases
{
    class Nodo
    {
        int dato;
        Nodo sig;
        public Nodo(int n)
        {
            dato = n;
            sig = null;
        }
        public Nodo siguiente
        {
            set { sig = value; }
            get { return sig; }
        }
        public int numero
        {
            set {dato=value; }
            get { return dato; }
        }
    }
}
