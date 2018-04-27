using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Clases
{
    public class Pila
    {
        Nodo  puntaP;
        int dim;
        public Pila()
        {
            puntaP = null;
            dim = 0;
        }
        public void Push(int dato)
        {
            Nodo n;
            if (puntaP == null)
            {
                n = new Nodo(dato);
            }
            else
            {
                n = new Nodo(dato);
                n.siguiente = puntaP;
            }
            puntaP = n;
            dim++;
        }
        public void pod()
        {
            if (puntaP!=null)
            {
                puntaP = puntaP.siguiente;
                dim--;
            }
        }
        public string mostrar()
        {
            if (puntaP == null)
                return "Null";
            else
                return puntaP.numero.ToString();

        }
        public int sumar()
        {
            int suma = 0;
            while (puntaP!= null)
            {
                suma = suma + puntaP.numero;
                puntaP = puntaP.siguiente;
            }
            return suma;
        }
        public void mostrartodo(DataGridView dt)
        {
            if (dim != 0)
            {


                dt.Columns.Clear();
                dt.Rows.Clear();
                dt.RowCount = dim;
                dt.ColumnCount = 1;
                int i = 0;
                Nodo aux = puntaP;
                while (aux != null)
                {
                    dt.Columns[0]. Width = 20;
                    
                    dt.Rows[i].Cells[0].Value = aux.numero;
                    aux = aux.siguiente;
                    i++;
                }
            }
        }
        public void dib(Panel p)
        {
            Graphic g = new Graphic(p, 0, 0);
            Nodo aux = puntaP;
            while (aux != null)
            {
                if (aux.siguiente == null)
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
