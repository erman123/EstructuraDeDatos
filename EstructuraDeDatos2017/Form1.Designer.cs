namespace EstructuraDeDatos2017
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PilasColas = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnListaDoble = new MetroFramework.Controls.MetroButton();
            this.btn_listadoblecircular = new MetroFramework.Controls.MetroButton();
            this.Btn_arbolBinario = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_PilasColas
            // 
            this.btn_PilasColas.Location = new System.Drawing.Point(164, 63);
            this.btn_PilasColas.Name = "btn_PilasColas";
            this.btn_PilasColas.Size = new System.Drawing.Size(222, 65);
            this.btn_PilasColas.TabIndex = 0;
            this.btn_PilasColas.Text = "Pilas y Colas";
            this.btn_PilasColas.UseSelectable = true;
            this.btn_PilasColas.Click += new System.EventHandler(this.btn_PilasColas_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(164, 134);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(222, 65);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Lista Simple";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnListaDoble
            // 
            this.btnListaDoble.Location = new System.Drawing.Point(164, 205);
            this.btnListaDoble.Name = "btnListaDoble";
            this.btnListaDoble.Size = new System.Drawing.Size(222, 65);
            this.btnListaDoble.TabIndex = 2;
            this.btnListaDoble.Text = "Lista Doble";
            this.btnListaDoble.UseSelectable = true;
            this.btnListaDoble.Click += new System.EventHandler(this.btnListaDoble_Click);
            // 
            // btn_listadoblecircular
            // 
            this.btn_listadoblecircular.Location = new System.Drawing.Point(164, 276);
            this.btn_listadoblecircular.Name = "btn_listadoblecircular";
            this.btn_listadoblecircular.Size = new System.Drawing.Size(222, 65);
            this.btn_listadoblecircular.TabIndex = 3;
            this.btn_listadoblecircular.Text = "Lista doble circular";
            this.btn_listadoblecircular.UseSelectable = true;
            this.btn_listadoblecircular.Click += new System.EventHandler(this.btn_listadoblecircular_Click);
            // 
            // Btn_arbolBinario
            // 
            this.Btn_arbolBinario.Location = new System.Drawing.Point(164, 347);
            this.Btn_arbolBinario.Name = "Btn_arbolBinario";
            this.Btn_arbolBinario.Size = new System.Drawing.Size(222, 65);
            this.Btn_arbolBinario.TabIndex = 4;
            this.Btn_arbolBinario.Text = "Arbol";
            this.Btn_arbolBinario.UseSelectable = true;
            this.Btn_arbolBinario.Click += new System.EventHandler(this.Btn_arbolBinario_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 463);
            this.Controls.Add(this.Btn_arbolBinario);
            this.Controls.Add(this.btn_listadoblecircular);
            this.Controls.Add(this.btnListaDoble);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_PilasColas);
            this.Name = "frmMenu";
            this.Text = "ESTRUCTURA DE DATOS BY ERMAN MENESES";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_PilasColas;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnListaDoble;
        private MetroFramework.Controls.MetroButton btn_listadoblecircular;
        private MetroFramework.Controls.MetroButton Btn_arbolBinario;
    }
}