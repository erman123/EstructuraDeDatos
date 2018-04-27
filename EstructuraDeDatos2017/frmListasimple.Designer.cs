namespace EstructuraDeDatos2017
{
    partial class frmListasimple
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
            this.btnInsertaprin = new MetroFramework.Controls.MetroButton();
            this.btnInsertaFina = new MetroFramework.Controls.MetroButton();
            this.btneliminarPrin = new MetroFramework.Controls.MetroButton();
            this.btneliminarfinal = new MetroFramework.Controls.MetroButton();
            this.txt_dato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertaprin
            // 
            this.btnInsertaprin.Location = new System.Drawing.Point(64, 78);
            this.btnInsertaprin.Name = "btnInsertaprin";
            this.btnInsertaprin.Size = new System.Drawing.Size(83, 23);
            this.btnInsertaprin.TabIndex = 0;
            this.btnInsertaprin.Text = "Insertar inicio";
            this.btnInsertaprin.UseSelectable = true;
            this.btnInsertaprin.Click += new System.EventHandler(this.btnInsertaprin_Click);
            // 
            // btnInsertaFina
            // 
            this.btnInsertaFina.Location = new System.Drawing.Point(153, 78);
            this.btnInsertaFina.Name = "btnInsertaFina";
            this.btnInsertaFina.Size = new System.Drawing.Size(75, 23);
            this.btnInsertaFina.TabIndex = 1;
            this.btnInsertaFina.Text = "Insertar final";
            this.btnInsertaFina.UseSelectable = true;
            this.btnInsertaFina.Click += new System.EventHandler(this.btnInsertaFina_Click);
            // 
            // btneliminarPrin
            // 
            this.btneliminarPrin.Location = new System.Drawing.Point(234, 78);
            this.btneliminarPrin.Name = "btneliminarPrin";
            this.btneliminarPrin.Size = new System.Drawing.Size(90, 23);
            this.btneliminarPrin.TabIndex = 2;
            this.btneliminarPrin.Text = "Eliminar inicio";
            this.btneliminarPrin.UseSelectable = true;
            this.btneliminarPrin.Click += new System.EventHandler(this.btneliminarPrin_Click);
            // 
            // btneliminarfinal
            // 
            this.btneliminarfinal.Location = new System.Drawing.Point(330, 78);
            this.btneliminarfinal.Name = "btneliminarfinal";
            this.btneliminarfinal.Size = new System.Drawing.Size(83, 23);
            this.btneliminarfinal.TabIndex = 3;
            this.btneliminarfinal.Text = "Eliminar final";
            this.btneliminarfinal.UseSelectable = true;
            this.btneliminarfinal.Click += new System.EventHandler(this.btneliminarfinal_Click);
            // 
            // txt_dato
            // 
            // 
            // 
            // 
            this.txt_dato.CustomButton.Image = null;
            this.txt_dato.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.txt_dato.CustomButton.Name = "";
            this.txt_dato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dato.CustomButton.TabIndex = 1;
            this.txt_dato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dato.CustomButton.UseSelectable = true;
            this.txt_dato.CustomButton.Visible = false;
            this.txt_dato.Lines = new string[0];
            this.txt_dato.Location = new System.Drawing.Point(23, 78);
            this.txt_dato.MaxLength = 32767;
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.PasswordChar = '\0';
            this.txt_dato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dato.SelectedText = "";
            this.txt_dato.SelectionLength = 0;
            this.txt_dato.SelectionStart = 0;
            this.txt_dato.ShortcutsEnabled = true;
            this.txt_dato.Size = new System.Drawing.Size(35, 23);
            this.txt_dato.TabIndex = 4;
            this.txt_dato.UseSelectable = true;
            this.txt_dato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(453, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Null";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(588, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Null";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 62);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 121);
            this.panel1.TabIndex = 8;
            // 
            // frmListasimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.btneliminarfinal);
            this.Controls.Add(this.btneliminarPrin);
            this.Controls.Add(this.btnInsertaFina);
            this.Controls.Add(this.btnInsertaprin);
            this.Name = "frmListasimple";
            this.Text = "Listasimple";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnInsertaprin;
        private MetroFramework.Controls.MetroButton btnInsertaFina;
        private MetroFramework.Controls.MetroButton btneliminarPrin;
        private MetroFramework.Controls.MetroButton btneliminarfinal;
        private MetroFramework.Controls.MetroTextBox txt_dato;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}