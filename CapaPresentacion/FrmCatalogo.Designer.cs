namespace CapaPresentacion
{
    partial class FrmCatalogo
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
            this.btnModerno = new System.Windows.Forms.Button();
            this.btnClasico = new System.Windows.Forms.Button();
            this.btnRustico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModerno
            // 
            this.btnModerno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnModerno.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModerno.ForeColor = System.Drawing.Color.Black;
            this.btnModerno.Location = new System.Drawing.Point(26, 22);
            this.btnModerno.Name = "btnModerno";
            this.btnModerno.Size = new System.Drawing.Size(152, 46);
            this.btnModerno.TabIndex = 11;
            this.btnModerno.Text = "Moderno";
            this.btnModerno.UseVisualStyleBackColor = false;
            this.btnModerno.Click += new System.EventHandler(this.btnModerno_Click_1);
            // 
            // btnClasico
            // 
            this.btnClasico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnClasico.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasico.ForeColor = System.Drawing.Color.Black;
            this.btnClasico.Location = new System.Drawing.Point(169, 22);
            this.btnClasico.Name = "btnClasico";
            this.btnClasico.Size = new System.Drawing.Size(152, 46);
            this.btnClasico.TabIndex = 12;
            this.btnClasico.Text = "Clásico";
            this.btnClasico.UseVisualStyleBackColor = false;
            this.btnClasico.Click += new System.EventHandler(this.btnClasico_Click_1);
            // 
            // btnRustico
            // 
            this.btnRustico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnRustico.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRustico.ForeColor = System.Drawing.Color.Black;
            this.btnRustico.Location = new System.Drawing.Point(310, 22);
            this.btnRustico.Name = "btnRustico";
            this.btnRustico.Size = new System.Drawing.Size(152, 46);
            this.btnRustico.TabIndex = 13;
            this.btnRustico.Text = "Rústico";
            this.btnRustico.UseVisualStyleBackColor = false;
            this.btnRustico.Click += new System.EventHandler(this.btnRustico_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 79);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.salida;
            this.pictureBox2.Location = new System.Drawing.Point(1026, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1106, 648);
            this.Controls.Add(this.btnRustico);
            this.Controls.Add(this.btnClasico);
            this.Controls.Add(this.btnModerno);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCatalogo";
            this.Text = "FrmCatalogo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModerno;
        private System.Windows.Forms.Button btnClasico;
        private System.Windows.Forms.Button btnRustico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}