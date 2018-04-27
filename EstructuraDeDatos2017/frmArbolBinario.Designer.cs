namespace EstructuraDeDatos2017
{
    partial class frmArbolBinario
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
            this.btn_insertarArbol = new MetroFramework.Controls.MetroButton();
            this.txt_dato = new MetroFramework.Controls.MetroTextBox();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.Btn_eliminarArbol = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_insertarArbol
            // 
            this.btn_insertarArbol.Location = new System.Drawing.Point(23, 123);
            this.btn_insertarArbol.Name = "btn_insertarArbol";
            this.btn_insertarArbol.Size = new System.Drawing.Size(75, 23);
            this.btn_insertarArbol.TabIndex = 1;
            this.btn_insertarArbol.Text = "Insertar";
            this.btn_insertarArbol.UseSelectable = true;
            this.btn_insertarArbol.Click += new System.EventHandler(this.btn_insertarArbol_Click);
            // 
            // txt_dato
            // 
            // 
            // 
            // 
            this.txt_dato.CustomButton.Image = null;
            this.txt_dato.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_dato.CustomButton.Name = "";
            this.txt_dato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dato.CustomButton.TabIndex = 1;
            this.txt_dato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dato.CustomButton.UseSelectable = true;
            this.txt_dato.CustomButton.Visible = false;
            this.txt_dato.Lines = new string[0];
            this.txt_dato.Location = new System.Drawing.Point(23, 94);
            this.txt_dato.MaxLength = 32767;
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.PasswordChar = '\0';
            this.txt_dato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dato.SelectedText = "";
            this.txt_dato.SelectionLength = 0;
            this.txt_dato.SelectionStart = 0;
            this.txt_dato.ShortcutsEnabled = true;
            this.txt_dato.Size = new System.Drawing.Size(75, 23);
            this.txt_dato.TabIndex = 2;
            this.txt_dato.UseSelectable = true;
            this.txt_dato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(104, 98);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 19);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Null";
            // 
            // Btn_eliminarArbol
            // 
            this.Btn_eliminarArbol.Location = new System.Drawing.Point(23, 152);
            this.Btn_eliminarArbol.Name = "Btn_eliminarArbol";
            this.Btn_eliminarArbol.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminarArbol.TabIndex = 4;
            this.Btn_eliminarArbol.Text = "altura";
            this.Btn_eliminarArbol.UseSelectable = true;
            this.Btn_eliminarArbol.Click += new System.EventHandler(this.Btn_eliminarArbol_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 181);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Imprmir or";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 210);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Imprmir pre";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 239);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "sumar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(23, 268);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(87, 23);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "Cantidad arbol";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 452);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Btn_eliminarArbol);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.btn_insertarArbol);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmArbolBinario";
            this.ShowIcon = false;
            this.Text = "frmArbolBinario";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmArbolBinario_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_insertarArbol;
        private MetroFramework.Controls.MetroTextBox txt_dato;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroButton Btn_eliminarArbol;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}