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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        int Dato = 0;
        int cont = 0;

        ArbolBinario mi_arbol = new ArbolBinario();
        Graphics g;

        private void btn_insertarArbol_Click(object sender, EventArgs e)
        {
            if (txt_dato.Text == "")
                MessageBox.Show("Debe ingresar un valor");
            else
            {
                Dato = int.Parse(txt_dato.Text);
                if (Dato < 0 || Dato >= 100)
                    MessageBox.Show("Solo recibe valores desde 1 hasta 99", "Error ingreso");
                else
                {

                    mi_arbol.insertar(Dato);
                    txt_dato.Clear();
                    txt_dato.Focus();

                    cont++;
                   // Graphics g = new Graphics(metroPanel1,)
                    Refresh();


                    Label1.Text = cont.ToString();
                }
            }
        }

        private void frmArbolBinario_Paint(object sender, PaintEventArgs e)
        {
             e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            mi_arbol.DibujarArbol(g, this.Font, Brushes.Orange, Brushes.DarkBlue, Pens.Purple, Brushes.White);
        }

        private void Btn_eliminarArbol_Click(object sender, EventArgs e)
        {

           MessageBox.Show( "la altura es "+mi_arbol.retornarAltura());
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mi_arbol.imprimirInOr();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            mi_arbol.imprimirPre();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           MessageBox.Show("La suma es"+ mi_arbol.sumaDatosArbol());
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           MessageBox.Show( "cantidad Arbol :"+mi_arbol.cantidadNodosArbol());
        }
    }
}
