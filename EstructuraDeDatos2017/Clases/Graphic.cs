using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos2017.Clases
{
    class Graphic
    {
        
            Graphics g;
            int x, y, angulo;
            public Graphic(Control c, int x, int y)
            {
                g = c.CreateGraphics();
                g.Clear(c.BackColor);
                this.x = x;
                this.y = y;
                this.angulo = 0;
            }
            public void DibujoNodoSimple(Pen p, Boolean der, int dato, int distancia, int w, int h)
            {

                g.DrawRectangle(p, x, y, w, h);
                g.DrawString(dato.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x, y);
                int n = Convert.ToInt32(w * 0.7);
                g.DrawLine(p, x + n, y, x + n, h);
                g.DrawLine(p, x + w, y + h / 2, x + distancia, y + h / 2);
                if (der)
                {
                g.DrawLine(p, x + distancia, Convert.ToInt32(h * 0.5), x + distancia, h * 2);//null derecho
                g.DrawLine(p, x + distancia - Convert.ToInt32(w * 0.2), h * 2, x + distancia + Convert.ToInt32(w * 0.2), h * 2);
                g.DrawLine(p, x + distancia - Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1), x + distancia + Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1));
            }
            else
                {
                int d = Convert.ToInt32(distancia * 0.9);
                g.DrawLine(p, x + d, y + Convert.ToInt32(h * 0.3), x + distancia, y + h / 2);
                g.DrawLine(p, x + d, y + Convert.ToInt32(h * 0.7), x + distancia, y + h / 2);
            }
                x += distancia;
            }
            public void DibujoNodoDoble(Pen p, Boolean i, Boolean d, int dato, int distancia, int w, int h)
            {
                g.DrawRectangle(p, x, y, w, h);

                int n = Convert.ToInt32(w * 0.75);
                g.DrawLine(p, x + n, y, x + n, h);//Caja de la referencia der
                int m = Convert.ToInt32(w * 0.25);
                g.DrawLine(p, x + m, y, x + m, h);//Caja de la referencia izq
                g.DrawString(dato.ToString(), new Font("Arial", Convert.ToInt32(h * 0.3)), new SolidBrush(Color.Black), x + m, y + Convert.ToInt32(h * 0.3));
                g.DrawLine(p, x, y + Convert.ToInt32(h * 0.8), x - (distancia - w), Convert.ToInt32(h * 0.8));//Referencia izquierda
                g.DrawLine(p, x + w, y + Convert.ToInt32(h * 0.2), x + distancia, Convert.ToInt32(h * 0.2));//Referencia Derecha
                if (d)
                {
                    g.DrawLine(p, x + distancia, Convert.ToInt32(h * 0.2), x + distancia, h * 2);//null derecho
                    g.DrawLine(p, x + distancia - Convert.ToInt32(w * 0.2), h * 2, x + distancia + Convert.ToInt32(w * 0.2), h * 2);
                    g.DrawLine(p, x + distancia - Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1), x + distancia + Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1));
                }
                else
                {
                    //FlechaDerecha
                    g.DrawLine(p, x + w + Convert.ToInt32((distancia - w) * 0.8), Convert.ToInt32(h * 0.1), x + distancia, Convert.ToInt32(h * 0.2));
                    g.DrawLine(p, x + w + Convert.ToInt32((distancia - w) * 0.8), Convert.ToInt32(h * 0.3), x + distancia, Convert.ToInt32(h * 0.2));
                }
                if (i)
                {
                    g.DrawLine(p, x - (distancia - w), Convert.ToInt32(h * 0.8), x - (distancia - w), h * 2);//null izq
                    g.DrawLine(p, x - (distancia - w) - Convert.ToInt32(w * 0.2), h * 2, x - (distancia - w) + Convert.ToInt32(w * 0.2), h * 2);
                    g.DrawLine(p, x - (distancia - w) - Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1), x - (distancia - w) + Convert.ToInt32(w * 0.1), Convert.ToInt32(h * 2.1));
                }
                else
                {
                    //flecha izq
                    g.DrawLine(p, x - Convert.ToInt32((distancia - w) * 0.8), Convert.ToInt32(h * 0.7), x - (distancia - w), Convert.ToInt32(h * 0.8));
                    g.DrawLine(p, x - Convert.ToInt32((distancia - w) * 0.8), Convert.ToInt32(h * 0.9), x - (distancia - w), Convert.ToInt32(h * 0.8));
                }
                x += distancia;
            }
            public void DibujoNodoCircular(Pen p, int r, int bloque, int dato)
            {
                int bloque2 = (int)(bloque * 0.8);

                //Punto( XF,YF) y Punto (XF2,YF2) en el Angulo Inicial 
                int xf = (int)(r * Math.Cos((angulo * Math.PI) / 180));
                int yf = (int)(r * Math.Sin((angulo * Math.PI) / 180));
                int xf2 = (int)((r * 0.7) * Math.Cos((angulo * Math.PI) / 180));
                int yf2 = (int)((r * 0.7) * Math.Sin((angulo * Math.PI) / 180));
                g.DrawLine(p, r + xf, r - yf, r + xf2, r - yf2);

                int xi = (int)(r * Math.Cos(((angulo + bloque2) * Math.PI) / 180));
                int yi = (int)(r * Math.Sin(((angulo + bloque2) * Math.PI) / 180));
                int xi2 = (int)((r * 0.7) * Math.Cos(((angulo + bloque2) * Math.PI) / 180));
                int yi2 = (int)((r * 0.7) * Math.Sin(((angulo + bloque2) * Math.PI) / 180));
                g.DrawLine(p, r + xi, r - yi, r + xi2, r - yi2);

                int xri = (int)(r * Math.Cos(((angulo + (bloque2 * 0.1)) * Math.PI) / 180));
                int yri = (int)(r * Math.Sin(((angulo + (bloque2 * 0.1)) * Math.PI) / 180));
                int xri2 = (int)((r * 0.7) * Math.Cos(((angulo + (bloque2 * 0.1)) * Math.PI) / 180));
                int yri2 = (int)((r * 0.7) * Math.Sin(((angulo + (bloque2 * 0.1)) * Math.PI) / 180));
                g.DrawLine(p, r + xri, r - yri, r + xri2, r - yri2);

                int xrd = (int)(r * Math.Cos(((angulo + (bloque2 * 0.9)) * Math.PI) / 180));
                int yrd = (int)(r * Math.Sin(((angulo + (bloque2 * 0.9)) * Math.PI) / 180));
                int xrd2 = (int)((r * 0.7) * Math.Cos(((angulo + (bloque2 * 0.9)) * Math.PI) / 180));
                int yrd2 = (int)((r * 0.7) * Math.Sin(((angulo + (bloque2 * 0.9)) * Math.PI) / 180));
                g.DrawLine(p, r + xrd, r - yrd, r + xrd2, r - yrd2);

                StringFormat df = new StringFormat();
                df.Alignment = StringAlignment.Center;
                df.LineAlignment = StringAlignment.Center;

                int xs = (int)((r * 0.85) * Math.Cos(((angulo + (bloque2 * 0.5)) * Math.PI) / 180));
                int ys = (int)((r * 0.85) * Math.Sin(((angulo + (bloque2 * 0.5)) * Math.PI) / 180));
                g.DrawString(dato.ToString(), new Font("Arial", 15), new SolidBrush(Color.Black), r + xs, r - ys, df);



                //Arco Extremo referencia
                g.DrawArc(p, (int)((r * 1.1) - r), (int)((r * 1.1) - r), (int)(r * 0.9) * 2, (int)(r * 0.9) * 2, -angulo - bloque2, -(bloque - bloque2));
                //Arco Inferior referencia
                g.DrawArc(p, (int)((r * 1.2) - r), (int)((r * 1.2) - r), (int)(r * 0.8) * 2, (int)(r * 0.8) * 2, -angulo - bloque2, -(bloque - bloque2));

                //Arco Extremo
                g.DrawArc(p, x, y, r * 2, r * 2, -angulo, -bloque2);
                //Arco Inferior
                g.DrawArc(p, (int)((r * 1.3) - r), (int)((r * 1.3) - r), (int)(r * 0.7) * 2, (int)(r * 0.7) * 2, -angulo, -bloque2);
                angulo += bloque;

            }
        

    }
}
