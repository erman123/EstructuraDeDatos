using EstructuraDeDatos2017.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Listadoble
{
    public class LiostaDobleCircular
    {
        NodoDoble puntero;
        int dim;
        public LiostaDobleCircular()
        {
            puntero = null;
            dim = 0;
        }
        public void insertarIzquierda(int d)
        {
            NodoDoble nuevo;
            if (puntero == null)
            {
                //lista circular todos apunta al puntero
                nuevo = new NodoDoble(d);
                puntero = nuevo;
                nuevo.Izquierda = nuevo;
                nuevo.Derecha = nuevo;
            }
            else
            {
                if (puntero.Izquierda == puntero)
                {
                    nuevo = new NodoDoble(d);
                    puntero.Derecha = nuevo;
                    puntero.Izquierda = nuevo;
                    nuevo.Derecha = puntero;
                    nuevo.Izquierda = puntero;
                }
                else
                {
                    nuevo = new NodoDoble(d);
                    nuevo.Derecha = puntero;
                    nuevo.Izquierda = puntero.Izquierda;
                    puntero.Izquierda.Derecha = nuevo;
                    puntero.Izquierda = nuevo;
                }
            }
            dim++;
        }
        public void insertarDerecha(int d)
        {
            NodoDoble nuevo;
            if (puntero == null)
            {
                nuevo = new NodoDoble(d);
                puntero = nuevo;
            }
            else
            {
                if (puntero.Derecha == puntero)
                {
                    nuevo = new NodoDoble(d);
                    puntero.Derecha = nuevo;
                    puntero.Izquierda = nuevo;
                    nuevo.Derecha = puntero;
                    nuevo.Izquierda = puntero;
                }
                else
                {
                    nuevo = new NodoDoble(d);
                    nuevo.Izquierda = puntero;
                    nuevo.Derecha = puntero.Derecha;
                    puntero.Derecha.Izquierda = nuevo;
                    puntero.Derecha = nuevo;
                }
            }
            dim++;
        }
        public void moverIzq()
        {
            puntero = puntero.Izquierda;
        }
        public void moverDer()
        {
            puntero = puntero.Derecha;
        }
        public void eliminar()
        {
            if (puntero != null)
            {
                if (puntero.Derecha == puntero)
                {
                    puntero = null;
                }
                else if (puntero.Izquierda == puntero.Derecha)
                {
                    puntero = puntero.Derecha;
                    puntero.Izquierda = puntero;
                    puntero.Derecha = puntero;
                }
                else
                {
                    puntero = puntero.Derecha;
                    puntero.Izquierda.Izquierda.Derecha = puntero;
                    puntero.Izquierda = puntero.Izquierda.Izquierda;
                }
                dim--;
            }
            else
            {
                MessageBox.Show("no hay nodos en la lista");
            }
        }
        public void Dibujar(Control c)
        {
            Graphic g = new Graphic(c, 0, 0);
            NodoDoble aux = puntero;
            if (dim >= 1)
            {
                int bloque = 360 / dim;


                for (int i = 0; i < dim; i++)
                {
                    if (aux == puntero)
                    {
                        g.DibujoNodoCircular(Pens.Orange, 220, bloque, aux.dato);
                    }
                    else
                    {
                        g.DibujoNodoCircular(Pens.Purple, 220, bloque, aux.dato);
                    }
                    aux = aux.Izquierda;
                }
            }
        }
    }
}
