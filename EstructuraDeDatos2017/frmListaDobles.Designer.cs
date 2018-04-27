namespace EstructuraDeDatos2017
{
    partial class frmListaDobles
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
            this.btnIzquierda = new MetroFramework.Controls.MetroButton();
            this.btnDerecha = new MetroFramework.Controls.MetroButton();
            this.btn_izqDer = new MetroFramework.Controls.MetroButton();
            this.btn_derIzq = new MetroFramework.Controls.MetroButton();
            this.btn_eliminar = new MetroFramework.Controls.MetroButton();
            this.txt_dato = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lb = new MetroFramework.Controls.MetroLabel();
            this.btnmaverizquierda = new MetroFramework.Controls.MetroButton();
            this.btnmoverderecha = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(44, 93);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 0;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseSelectable = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(168, 93);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseSelectable = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btn_izqDer
            // 
            this.btn_izqDer.Location = new System.Drawing.Point(44, 119);
            this.btn_izqDer.Name = "btn_izqDer";
            this.btn_izqDer.Size = new System.Drawing.Size(75, 23);
            this.btn_izqDer.TabIndex = 2;
            this.btn_izqDer.Text = "izq-a-Der";
            this.btn_izqDer.UseSelectable = true;
            this.btn_izqDer.Click += new System.EventHandler(this.btn_izqDer_Click);
            // 
            // btn_derIzq
            // 
            this.btn_derIzq.Location = new System.Drawing.Point(168, 119);
            this.btn_derIzq.Name = "btn_derIzq";
            this.btn_derIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_derIzq.TabIndex = 3;
            this.btn_derIzq.Text = "Der-a-Izq";
            this.btn_derIzq.UseSelectable = true;
            this.btn_derIzq.Click += new System.EventHandler(this.btn_derIzq_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(43, 145);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(200, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseSelectable = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_dato
            // 
            // 
            // 
            // 
            this.txt_dato.CustomButton.Image = null;
            this.txt_dato.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txt_dato.CustomButton.Name = "";
            this.txt_dato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dato.CustomButton.TabIndex = 1;
            this.txt_dato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dato.CustomButton.UseSelectable = true;
            this.txt_dato.CustomButton.Visible = false;
            this.txt_dato.Lines = new string[0];
            this.txt_dato.Location = new System.Drawing.Point(125, 93);
            this.txt_dato.MaxLength = 32767;
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.PasswordChar = '\0';
            this.txt_dato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dato.SelectedText = "";
            this.txt_dato.SelectionLength = 0;
            this.txt_dato.SelectionStart = 0;
            this.txt_dato.ShortcutsEnabled = true;
            this.txt_dato.Size = new System.Drawing.Size(37, 23);
            this.txt_dato.TabIndex = 5;
            this.txt_dato.UseSelectable = true;
            this.txt_dato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 75);
            this.dataGridView1.TabIndex = 6;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(44, 237);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(698, 187);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(312, 60);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 19);
            this.lb.TabIndex = 8;
            this.lb.Text = "Null";
            // 
            // btnmaverizquierda
            // 
            this.btnmaverizquierda.Location = new System.Drawing.Point(43, 198);
            this.btnmaverizquierda.Name = "btnmaverizquierda";
            this.btnmaverizquierda.Size = new System.Drawing.Size(75, 23);
            this.btnmaverizquierda.TabIndex = 9;
            this.btnmaverizquierda.Text = "<<";
            this.btnmaverizquierda.UseSelectable = true;
            this.btnmaverizquierda.Click += new System.EventHandler(this.btnmaverizquierda_Click);
            // 
            // btnmoverderecha
            // 
            this.btnmoverderecha.Location = new System.Drawing.Point(168, 198);
            this.btnmoverderecha.Name = "btnmoverderecha";
            this.btnmoverderecha.Size = new System.Drawing.Size(75, 23);
            this.btnmoverderecha.TabIndex = 10;
            this.btnmoverderecha.Text = ">>";
            this.btnmoverderecha.UseSelectable = true;
            this.btnmoverderecha.Click += new System.EventHandler(this.btnmoverderecha_Click);
            // 
            // frmListaDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 447);
            this.Controls.Add(this.btnmoverderecha);
            this.Controls.Add(this.btnmaverizquierda);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_derIzq);
            this.Controls.Add(this.btn_izqDer);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Name = "frmListaDobles";
            this.Text = "frmListaDobles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIzquierda;
        private MetroFramework.Controls.MetroButton btnDerecha;
        private MetroFramework.Controls.MetroButton btn_izqDer;
        private MetroFramework.Controls.MetroButton btn_derIzq;
        private MetroFramework.Controls.MetroButton btn_eliminar;
        private MetroFramework.Controls.MetroTextBox txt_dato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lb;
        private MetroFramework.Controls.MetroButton btnmaverizquierda;
        private MetroFramework.Controls.MetroButton btnmoverderecha;
    }
}