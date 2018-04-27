using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Clases
{
    public class Lista
    {
        Nodo punteroLis;
        Nodo ultimoLis;
        int dim;
        public Lista()
        {
            punteroLis = null;
            ultimoLis = null;
            dim = 0;
        }
        public void insertarUltimo(int d)
        {
            Nodo nuevo;
            if (punteroLis == null && ultimoLis == null)
            {
                nuevo = new Nodo(d);
                punteroLis = nuevo;
                ultimoLis = nuevo;
            }
            else
            {
                nuevo = new Nodo(d);
                //ultimo.siguiente == referencia a anterior
                ultimoLis.siguiente = nuevo;
                ultimoLis = nuevo;
            }
            dim++;
        }
        public void insertarPrimero(int d)
        {
            Nodo nuevo;
            if (ultimoLis == null && punteroLis == null)
            {
                nuevo = new Nodo(d);
                ultimoLis = nuevo;
                punteroLis = nuevo;

            }
            else
            {
                nuevo = new Nodo(d);
                nuevo.siguiente = punteroLis;
                punteroLis = nuevo;

            }
            dim++;
        }
        public void eliminarPrimero()
        {
            if (punteroLis!=null)
            {
                punteroLis = punteroLis.siguiente;
                dim--;
            }
            if (punteroLis==null)
                ultimoLis = null;
        }
        public void eliminarUltimo()
        {
            Nodo correnodo = punteroLis;
            if (correnodo!=ultimoLis)
            {
                while (!correnodo.siguiente.Equals(ultimoLis))
                    correnodo = correnodo.siguiente;
                correnodo.siguiente = null;
                ultimoLis = correnodo;
                dim--;
            }
        }
        public string mostarPrimero()
        {
            if (punteroLis == null)
                return "Null";
            else
                return punteroLis.numero.ToString();
        }
        public string mostrarUltimo()
        {
            if (ultimoLis != null)
                return ultimoLis.numero.ToString();
            else
                return "Null";
        }
        public string mostrarTodo()
        {
            Nodo ax = punteroLis;
            string cad = default(string);
            while (ax!=ultimoLis)
            {
                cad += " " + ax.numero;
                ax = ax.siguiente;
            }
            cad += " " + ax.numero;
            return cad;
        }
        public void mostrarTodo(DataGridView dt)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.RowCount = 1;
            dt.ColumnCount = dim;
            Nodo ax = punteroLis;
            int i = 0;
            for (i = 0;  ax!=null; i++)
            {
                dt.Columns[i].Width = 20;
                dt.Rows[0].Cells[i].Value = ax.numero;
                ax = ax.siguiente;
            }
            
        }
        public void dibujar(Panel p)
        {
            Graphic grp = new Graphic(p, 0, 0);
            Nodo ax = punteroLis;
            while (ax!= null)
            {
                if (ax == punteroLis)
                    grp.DibujoNodoSimple(Pens.DarkOrange, ax.siguiente == null, ax.numero, 70, 50, 20);
                else if (ax == ultimoLis)
                    grp.DibujoNodoSimple(Pens.DarkOrange, ax.siguiente == null, ax.numero, 70, 50, 20);
                else
                    grp.DibujoNodoSimple(Pens.DarkOrange, ax.siguiente == null, ax.numero, 70, 50, 20);
                ax = ax.siguiente;
            }
        }
    }
}
