using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Clases
{
    public class Cola
    {
        Nodo punteroCola;
        Nodo ultimoCola;
        int dim;
        public Cola()
        {
            punteroCola = null;
            ultimoCola = null;
            dim = 0;
        }
        public void insertar(int d)
        {
            Nodo nuevo;
            if (punteroCola==null && ultimoCola==null)
            {
                nuevo = new Nodo(d);
                punteroCola = nuevo;
                ultimoCola = nuevo;
            }
            else
            {
                nuevo = new Nodo(d);
                ultimoCola.siguiente = nuevo;
                ultimoCola = nuevo;
            }
            dim++;
        }

        public void eliminar()
        {
            if (punteroCola != null)
            {
                punteroCola = punteroCola.siguiente;
                dim--;
            }
            if (punteroCola == null)
            {
                ultimoCola = null;
            }
        }
        public string Mostrar()
        {
            if (punteroCola != null)
            {
                return punteroCola.numero.ToString();
            }
            else
            {
                 return "Null";
            }
        }
        public void Mostrar(DataGridView dg)
        {
            if (dim != 0)
            {


                dg.Columns.Clear();
                dg.Rows.Clear();
                dg.RowCount = 1;
                dg.ColumnCount = dim;
                dg.RowHeadersWidth = 10;

                int i = 0;
                Nodo aux = punteroCola;
                while (aux != null)
                {
                    dg.Columns[i].Width = 20;
                    dg.Rows[0].Cells[i].Value = aux.numero;
                    aux = aux.siguiente;
                    i++;

                }
            }
        }
        public void dib(Panel p)
        {
            Graphic g = new Graphic(p, 0, 0);
            Nodo aux = punteroCola;
            while (aux != null)
            {
                if (aux == punteroCola)
                {
                    g.DibujoNodoSimple(Pens.Blue, aux.siguiente == null, aux.numero, 70, 50, 20);
                }
                else if (aux == ultimoCola)
                {
                    g.DibujoNodoSimple(Pens.Green, aux.siguiente == null, aux.numero, 70, 50, 20);
                }
                else
                {
                    g.DibujoNodoSimple(Pens.Black, aux.siguiente == null, aux.numero, 70, 50, 20);
                }

                aux = aux.siguiente;
            }

        }
    }
}
