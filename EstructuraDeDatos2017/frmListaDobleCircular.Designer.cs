namespace EstructuraDeDatos2017
{
    partial class frmListaDobleCircular
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
            this.btn_izq = new MetroFramework.Controls.MetroButton();
            this.btn_derecha = new MetroFramework.Controls.MetroButton();
            this.btn_eliminar = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.txt_dato = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // btn_izq
            // 
            this.btn_izq.Location = new System.Drawing.Point(23, 74);
            this.btn_izq.Name = "btn_izq";
            this.btn_izq.Size = new System.Drawing.Size(75, 23);
            this.btn_izq.TabIndex = 0;
            this.btn_izq.Text = "izquierda";
            this.btn_izq.UseSelectable = true;
            this.btn_izq.Click += new System.EventHandler(this.btn_izq_Click);
            // 
            // btn_derecha
            // 
            this.btn_derecha.Location = new System.Drawing.Point(146, 74);
            this.btn_derecha.Name = "btn_derecha";
            this.btn_derecha.Size = new System.Drawing.Size(75, 23);
            this.btn_derecha.TabIndex = 1;
            this.btn_derecha.Text = "Derecha";
            this.btn_derecha.UseSelectable = true;
            this.btn_derecha.Click += new System.EventHandler(this.btn_derecha_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(83, 103);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseSelectable = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(323, 103);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "<<";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(473, 103);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = ">>";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
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
            this.txt_dato.Location = new System.Drawing.Point(104, 74);
            this.txt_dato.MaxLength = 32767;
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.PasswordChar = '\0';
            this.txt_dato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dato.SelectedText = "";
            this.txt_dato.SelectionLength = 0;
            this.txt_dato.SelectionStart = 0;
            this.txt_dato.ShortcutsEnabled = true;
            this.txt_dato.Size = new System.Drawing.Size(36, 23);
            this.txt_dato.TabIndex = 5;
            this.txt_dato.UseSelectable = true;
            this.txt_dato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(104, 148);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(617, 555);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // frmListaDobleCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 726);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_derecha);
            this.Controls.Add(this.btn_izq);
            this.Name = "frmListaDobleCircular";
            this.Text = "frmListaDobleCircular";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_izq;
        private MetroFramework.Controls.MetroButton btn_derecha;
        private MetroFramework.Controls.MetroButton btn_eliminar;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox txt_dato;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}