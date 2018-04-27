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
   public class ListaDoble
    {
        NodoDoble puntero;
        NodoDoble izq;
        NodoDoble der;
        public ListaDoble()
        {
            puntero = null;
            izq = null;
            der = null;
        }
        public void insertarIzquierda(int d)
        {
            NodoDoble nuevo;
            if (puntero == null)
            {
                nuevo = new NodoDoble(d);
                puntero = nuevo;
                izq = nuevo;
                der = nuevo;
            }
            else
            {
                if (puntero.Izquierda == null)
                {
                    nuevo = new NodoDoble(d);
                    nuevo.Derecha = puntero;
                    puntero.Izquierda = nuevo;
                    izq = nuevo;
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
            
        }
        public void insertarDerecha(int d)
        {
            NodoDoble nuevo;
            if (puntero == null)
            {
                nuevo = new NodoDoble(d);
                puntero = nuevo;
                izq = nuevo;
                der = nuevo;
            }
            else
            {
                if (puntero.Derecha == null)
                {
                    nuevo = new NodoDoble(d);
                    nuevo.Izquierda = nuevo;
                    puntero.Derecha = nuevo;
                    der = nuevo;

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
        }
        public void moverIzquierda()
        {
            if (puntero != null)
            {
                if (puntero.Izquierda != null)
                    puntero = puntero.Izquierda;
            }
            else
                MessageBox.Show("sin noos en la lista");
        }
        public void moverDerecha()
        {
            if (puntero!=null)
            {
                if (puntero.Derecha!=null)
                {
                    puntero = puntero.Derecha;
                }
            }else
            {

                MessageBox.Show("Sin nodo en la lista");
            }
        }
        public string mostrar()
        {
            if (puntero == null)
            {
                return "Null";
            }
            else
            {
                return puntero.dato.ToString();
            }

        }
        public void eliminar()
        {
            if (puntero != null)
            {
                if (puntero.Izquierda == null && puntero.Derecha == null)
                {
                    puntero = null;
                    izq = null;
                    der = null;
                }
                else if (puntero.Izquierda == null && puntero.Derecha != null)
                {
                    izq = puntero.Derecha;
                    puntero = puntero.Derecha;
                    puntero.Izquierda.Derecha = null;
                    puntero.Izquierda = null;
                }
                else if (puntero.Derecha == null && puntero.Izquierda != null)//01
                {
                    der = puntero.Izquierda;
                    puntero = puntero.Izquierda;
                    puntero.Derecha.Izquierda = null;
                    puntero.Derecha = null;
                }
                else if (puntero.Derecha != null && puntero.Izquierda != null)//010
                {
                    puntero = puntero.Izquierda;
                    puntero.Derecha.Derecha.Izquierda = puntero;
                    puntero.Derecha = puntero.Derecha.Derecha;
                }
                else
                {
                    MessageBox.Show("no hay nodos en la lista");
                }
            }
        }
        public void mostrarizqder(DataGridView dg)
        {
            dg.Rows.Clear();
            dg.Columns.Clear();
            dg.ColumnHeadersVisible = false;
            dg.RowHeadersVisible = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            NodoDoble corre = izq;
            int i = 0;
            while (corre != null)
            {
                DataGridViewColumn dgc = new DataGridViewColumn(new DataGridViewTextBoxCell());
                dgc.Name = "c1";
                dgc.HeaderText = "";
                dg.Columns.Add(dgc);
                dg.Rows[0].Cells[i].Value = corre.dato;
                corre = corre.Derecha;
                i++;
            }
        }
        public void mostrarderizq(DataGridView dg)
        {
            dg.Rows.Clear();
            dg.Columns.Clear();
            dg.ColumnHeadersVisible = false;
            dg.RowHeadersVisible = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            NodoDoble corre = der;
            int i = 0;
            while (corre != null)
            {
                DataGridViewColumn dgc = new DataGridViewColumn(new DataGridViewTextBoxCell());
                dgc.Name = "c1";
                dgc.HeaderText = "";
                dg.Columns.Add(dgc);
                dg.Rows[0].Cells[i].Value = corre.dato;
                corre = corre.Izquierda;
                i++;
            }

        }
        
        public void dibujar(Control p)
        {
            Graphic g = new Graphic(p, 100, 0);
            NodoDoble aux = izq;
            while (aux != null)
            {
                if (aux == puntero)
                {
                    g.DibujoNodoDoble(Pens.Orange, aux.Izquierda == null, aux.Derecha == null, aux.dato, 80, 50, 30);
                }
                else if (aux == izq)
                {
                    g.DibujoNodoDoble(Pens.Green, aux.Izquierda == null, aux.Derecha == null, aux.dato, 80, 50, 30);
                }
                else if (aux == der)
                {
                    g.DibujoNodoDoble(Pens.Purple, aux.Izquierda == null, aux.Derecha == null, aux.dato, 80, 50, 30);
                }
                else
                {
                    g.DibujoNodoDoble(Pens.Black, aux.Izquierda == null, aux.Derecha == null, aux.dato, 80, 50, 30);
                }
                aux = aux.Derecha;
            }
        }
    }
}
