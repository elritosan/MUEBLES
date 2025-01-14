namespace CapaPresentacion
{
    partial class FrmIniciarSesion
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
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Ejecutar = new System.Windows.Forms.Button();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.Lbl_Contrasenia = new System.Windows.Forms.Label();
            this.Lbl_Correo = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.Black;
            this.Btn_Registrar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Registrar.Location = new System.Drawing.Point(236, 485);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(183, 75);
            this.Btn_Registrar.TabIndex = 41;
            this.Btn_Registrar.Text = "REGISTRARSE";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Ejecutar
            // 
            this.Btn_Ejecutar.BackColor = System.Drawing.Color.Black;
            this.Btn_Ejecutar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ejecutar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ejecutar.Location = new System.Drawing.Point(55, 485);
            this.Btn_Ejecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ejecutar.Name = "Btn_Ejecutar";
            this.Btn_Ejecutar.Size = new System.Drawing.Size(162, 75);
            this.Btn_Ejecutar.TabIndex = 39;
            this.Btn_Ejecutar.Text = "INICIAR SESIÓN";
            this.Btn_Ejecutar.UseVisualStyleBackColor = false;
            this.Btn_Ejecutar.Click += new System.EventHandler(this.Btn_Ejecutar_Click);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.TxtContrasenia.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.ForeColor = System.Drawing.Color.Black;
            this.TxtContrasenia.Location = new System.Drawing.Point(31, 358);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(389, 34);
            this.TxtContrasenia.TabIndex = 38;
            // 
            // Lbl_Contrasenia
            // 
            this.Lbl_Contrasenia.AutoSize = true;
            this.Lbl_Contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.Lbl_Contrasenia.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contrasenia.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contrasenia.Location = new System.Drawing.Point(18, 307);
            this.Lbl_Contrasenia.Name = "Lbl_Contrasenia";
            this.Lbl_Contrasenia.Size = new System.Drawing.Size(156, 28);
            this.Lbl_Contrasenia.TabIndex = 36;
            this.Lbl_Contrasenia.Text = "Contraseña:";
            // 
            // Lbl_Correo
            // 
            this.Lbl_Correo.AutoSize = true;
            this.Lbl_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.Lbl_Correo.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Correo.Location = new System.Drawing.Point(17, 199);
            this.Lbl_Correo.Name = "Lbl_Correo";
            this.Lbl_Correo.Size = new System.Drawing.Size(100, 28);
            this.Lbl_Correo.TabIndex = 35;
            this.Lbl_Correo.Text = "Correo:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuario.Location = new System.Drawing.Point(22, 247);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(397, 34);
            this.TxtUsuario.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 140);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(113, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(458, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Btn_Ejecutar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.Lbl_Contrasenia);
            this.Controls.Add(this.Lbl_Correo);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "FrmIniciarSesion";
            this.Opacity = 0.9D;
            this.Text = "FrmIniciarSesion";
            this.Load += new System.EventHandler(this.FrmIniciarSesion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Ejecutar;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Label Lbl_Contrasenia;
        private System.Windows.Forms.Label Lbl_Correo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}