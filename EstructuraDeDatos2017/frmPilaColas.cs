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
using EstructuraDeDatos2017.Clases;

namespace EstructuraDeDatos2017
{
    public partial class frmPilaColas : MetroFramework.Forms.MetroForm
    {
        public frmPilaColas()
        {
            InitializeComponent();
        }
        Pila p = new Pila();
        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (!metroTextBox1.Text.Equals(""))
            {
                p.Push(int.Parse(metroTextBox1.Text));
                metroLabel1.Text= p.mostrar();
                p.mostrartodo(dataGridView1);
                metroTextBox1.Clear();
                metroTextBox1.Focus();
                p.dib(metroPanel1);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            p.pod();
            metroLabel1.Text = p.mostrar();
            p.mostrartodo(dataGridView1);
            p.dib(metroPanel1);
        }

        Cola c = new Cola();
        private void btn_insertaCola_Click(object sender, EventArgs e)
        {
            if (!metroTextBox2.Text.Equals(""))
            {
                c.insertar(int.Parse(metroTextBox2.Text));
                metroLabel2.Text = c.Mostrar();
                c.Mostrar(dataGridView2);
                c.dib(metroPanel2);
                metroTextBox2.Clear();
                metroTextBox2.Focus();
            }
        }

        private void btn_eliminarPila_Click(object sender, EventArgs e)
        {
            c.eliminar();
            c.Mostrar(dataGridView2);
            metroLabel2.Text = c.Mostrar();
            c.dib(metroPanel2);
            metroTextBox2.Clear();
            metroTextBox2.Focus();
        }
    }
}
