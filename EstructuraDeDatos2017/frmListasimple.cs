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
    public partial class frmListasimple : MetroFramework.Forms.MetroForm
    {
        public frmListasimple()
        {
            InitializeComponent();
        }
        Lista l = new Lista(); 
        private void btnInsertaprin_Click(object sender, EventArgs e)
        {
            l.insertarPrimero(int.Parse(txt_dato.Text));
            metroLabel1.Text= l.mostarPrimero();
            metroLabel2.Text = l.mostrarUltimo();
            l.mostrarTodo(dataGridView1);
            txt_dato.Clear();
            txt_dato.Focus();
            l.dibujar(panel1);
        }

        private void btnInsertaFina_Click(object sender, EventArgs e)
        {
            l.insertarUltimo(int.Parse(txt_dato.Text));
            metroLabel1.Text = l.mostarPrimero();
            metroLabel2.Text = l.mostrarUltimo();
            l.mostrarTodo(dataGridView1);
            l.dibujar(panel1);
            txt_dato.Clear();
            txt_dato.Focus();
        }

        private void btneliminarPrin_Click(object sender, EventArgs e)
        {
            l.eliminarPrimero();
            metroLabel1.Text = l.mostarPrimero();
            metroLabel2.Text = l.mostrarUltimo();
            l.mostrarTodo(dataGridView1);
            l.dibujar(panel1);
            txt_dato.Clear();
            txt_dato.Focus();
        }

        private void btneliminarfinal_Click(object sender, EventArgs e)
        {
            l.eliminarUltimo();
            metroLabel1.Text = l.mostarPrimero();
            metroLabel2.Text = l.mostrarUltimo();
            l.mostrarTodo(dataGridView1);
            l.dibujar(panel1);
            txt_dato.Clear();
            txt_dato.Focus();
        }
    }
}
