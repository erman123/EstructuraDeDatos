using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos2017.Listadoble
{
   public  class nodoA
    {
        public int dato { get; set; }
        public nodoA IZQ { get; set; }
        public nodoA DER { get; set; }
        public nodoA(int d)
        {
            dato = d;
        }

      
        private const int Radio = 30;
        private const int DistanciaH = 80;
        private const int DistanciaV = 10;


        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            if (IZQ != null)
                IZQ.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            if (IZQ != null && DER != null)
                xmin += DistanciaH;
            if (DER != null)
                DER.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            if (IZQ != null && DER != null)
                CoordenadaX = (int)((IZQ.CoordenadaX + DER.CoordenadaX) / 2);
            else if (IZQ != null)
            {
                aux1 = IZQ.CoordenadaX;
                IZQ.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (DER != null)
            {
                aux2 = DER.CoordenadaX;
                DER.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (IZQ != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, IZQ.CoordenadaX, IZQ.CoordenadaY);
                IZQ.DibujarRamas(grafo, Lapiz);
            }
            if (DER != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, DER.CoordenadaX, DER.CoordenadaY);
                DER.DibujarRamas(grafo, Lapiz);
            }
        }
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);

            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);

            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(dato.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);

            if (IZQ != null)
            {
                IZQ.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
            if (DER != null)
            {
                DER.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
        }
    }
}
