using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using EstructuraDeDatos2017.Listadoble;
namespace EstructuraDeDatos2017
{
    public partial class frmListaDobleCircular : MetroFramework.Forms.MetroForm
    {
        public frmListaDobleCircular()
        {
            InitializeComponent();
        }
        LiostaDobleCircular ldc = new LiostaDobleCircular();
        private void btn_izq_Click(object sender, EventArgs e)
        {
            ldc.insertarIzquierda(int.Parse(txt_dato.Text));
            ldc.Dibujar(metroPanel1);
            txt_dato.Clear();
            txt_dato.Focus();
        }

        private void btn_derecha_Click(object sender, EventArgs e)
        {
            ldc.insertarDerecha(int.Parse(txt_dato.Text));
            ldc.Dibujar(metroPanel1);
            txt_dato.Clear();
            txt_dato.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ldc.eliminar();
            ldc.Dibujar(metroPanel1);
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ldc.moverIzq();
            ldc.Dibujar(metroPanel1);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ldc.moverDer();
            ldc.Dibujar(metroPanel1);
        }
    }
}
