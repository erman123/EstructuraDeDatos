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
    public partial class frmListaDobles : MetroFramework.Forms.MetroForm
    {
        public frmListaDobles()
        {
            InitializeComponent();
        }
        ListaDoble ld = new ListaDoble();
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (!txt_dato.Text.Equals(""))
            {
                ld.insertarIzquierda(int.Parse(txt_dato.Text));
                lb.Text = ld.mostrar();
                txt_dato.Clear();
                txt_dato.Focus();
                ld.dibujar(metroPanel1);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            ld.insertarDerecha(int.Parse(txt_dato.Text));
            lb.Text = ld.mostrar();
            txt_dato.Clear();
            txt_dato.Focus();
            ld.dibujar(metroPanel1);
        }

        private void btn_izqDer_Click(object sender, EventArgs e)
        {
            ld.mostrarizqder(dataGridView1);
        }

        private void btn_derIzq_Click(object sender, EventArgs e)
        {
            ld.mostrarderizq(dataGridView1);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ld.eliminar();
            lb.Text = ld.mostrar();
            txt_dato.Clear();
            txt_dato.Focus();
            ld.dibujar(metroPanel1);
        }

        private void btnmaverizquierda_Click(object sender, EventArgs e)
        {
            ld.moverIzquierda();
            lb.Text= ld.mostrar();
            ld.dibujar(metroPanel1);
        }

        private void btnmoverderecha_Click(object sender, EventArgs e)
        {
            ld.moverDerecha();
            lb.Text = ld.mostrar();
            ld.dibujar(metroPanel1);
        }
    }
}
