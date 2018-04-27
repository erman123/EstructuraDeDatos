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
namespace EstructuraDeDatos2017
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        bool fpc = true;
        frmPilaColas frmpc;
        private void btn_PilasColas_Click(object sender, EventArgs e)
        {
            if (fpc || frmpc.IsDisposed)
            {
                frmpc = new  frmPilaColas();
                fpc = false;
                frmpc.Show();
            }
        }
        frmListasimple frmls;
        bool blis = true;
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (blis || frmls.IsDisposed)
            {
                frmls = new frmListasimple();
                frmls.Show();
                blis = false;
            }
        }
        bool bld = true;
        frmListaDobles frmld;
        private void btnListaDoble_Click(object sender, EventArgs e)
        {
            if (bld||frmld.IsDisposed)
            {
                frmld = new frmListaDobles();
                frmld.Show();
                bld = false;
            }
        }
        bool bldc = true;
        frmListaDobleCircular frmldc;
        private void btn_listadoblecircular_Click(object sender, EventArgs e)
        {
            if (bldc||frmldc.IsDisposed)
            {
                frmldc = new frmListaDobleCircular();
                frmldc.Show();
                bldc = false;
            }
        }
        bool ab = true;
        frmArbolBinario frmab;
        private void Btn_arbolBinario_Click(object sender, EventArgs e)
        {
            if (ab||frmab.IsDisposed)
            {
                frmab = new frmArbolBinario();
                frmab.Show();
                ab = false;
            }
        }
    }
}
