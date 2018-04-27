using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructuraDeDatos2017.Listadoble;
using System.Drawing;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Listadoble
{
    public class ArbolBinario
    {
        public nodoA RAIZ;
        public int nn, altura;
        public ArbolBinario()
        {
            RAIZ = null;
        }
        public void insertar(int dato)
        {
            nodoA nuevo;
            nuevo = new nodoA(dato);
            if (RAIZ == null)
            {
                RAIZ = nuevo;
            }
            else
            {
                nodoA anterior = null, reco;
                reco = RAIZ;
                while (reco != null)
                {
                    anterior = reco;
                    if (dato < reco.dato)
                        reco = reco.IZQ;
                    else
                        reco = reco.DER;
                }
                if (dato < anterior.dato)
                    anterior.IZQ = nuevo;
                else
                    anterior.DER = nuevo;
            }
        }

        private void imprimirPre(nodoA reco)
        {
            if (reco != null)
            {
                MessageBox.Show(reco.dato + " ");
                imprimirPre(reco.IZQ);
                imprimirPre(reco.DER);
            }
        }
        public void imprimirPre()
        {
            imprimirPre(RAIZ);
        }
        private string imprimirInOr(nodoA reco)
        {
            string cad = "";
            if (reco != null)
            {
                imprimirInOr(reco.IZQ);
                MessageBox.Show(reco.dato + " ");
               // cad = cad + reco.dato + " ";
                imprimirInOr(reco.DER);
            }
            return cad;
        }
        public void imprimirInOr()
        {
           imprimirInOr(RAIZ);
        }
        public int cantidadNodosArbol()
        {
            nn = 0;
            contarNodos(RAIZ);
            return nn;
        }
        private void contarNodos(nodoA narbol)
        {
            if (narbol != null)
            {
                nn++;
                contarNodos(narbol.DER);
                contarNodos(narbol.IZQ);
            }
        }
        public int sumaDatosArbol()
        {
            nn = 0;
            sumaDatosArbol(RAIZ);
            return nn;
        }
        private void sumaDatosArbol(nodoA narbol)
        {
            if (narbol != null)
            {
                nn = nn + narbol.dato;
                sumaDatosArbol(narbol.DER);
                sumaDatosArbol(narbol.IZQ);
            }
        }
        public int retornarAltura()
        {
            altura = 0;
            retornarAltura(RAIZ, 1);
            return altura;
        }
        private void retornarAltura(nodoA nArbol, int nivel)
        {
            if (nArbol != null)
            {
                retornarAltura(nArbol.IZQ, nivel + 1);
                if (nivel > altura)
                {
                    altura = nivel;
                }
                retornarAltura(nArbol.DER, nivel + 1);
            }
        }

        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400;
            int y = 75;
            if (RAIZ == null) return;

            RAIZ.PosicionNodo(ref x, y);
            RAIZ.DibujarRamas(grafo, Lapiz);
            RAIZ.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }
    }
}
