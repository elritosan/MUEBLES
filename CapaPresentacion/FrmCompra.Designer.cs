namespace CapaPresentacion
{
    partial class FrmCompra
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.Vista_Factura = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubirBajar_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.CmbNombre = new System.Windows.Forms.ComboBox();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnModerno = new System.Windows.Forms.Button();
            this.btnclasico = new System.Windows.Forms.Button();
            this.btnRustico = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubirBajar_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.Vista_Factura);
            this.panel1.Controls.Add(this.SubirBajar_Cantidad);
            this.panel1.Controls.Add(this.CmbNombre);
            this.panel1.Controls.Add(this.PbxFoto);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblEstilo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMaterial);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 669);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Black;
            this.btnPagar.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(311, 606);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(164, 44);
            this.btnPagar.TabIndex = 29;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Vista_Factura
            // 
            this.Vista_Factura.AllowUserToAddRows = false;
            this.Vista_Factura.AllowUserToDeleteRows = false;
            this.Vista_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vista_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4});
            this.Vista_Factura.Location = new System.Drawing.Point(21, 350);
            this.Vista_Factura.Name = "Vista_Factura";
            this.Vista_Factura.ReadOnly = true;
            this.Vista_Factura.RowHeadersWidth = 51;
            this.Vista_Factura.RowTemplate.Height = 24;
            this.Vista_Factura.Size = new System.Drawing.Size(554, 207);
            this.Vista_Factura.TabIndex = 31;
            this.Vista_Factura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vista_Factura_CellContentClick);
            // 
            // C1
            // 
            this.C1.HeaderText = "Tipo";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 125;
            // 
            // C2
            // 
            this.C2.HeaderText = "Precio";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 125;
            // 
            // C3
            // 
            this.C3.HeaderText = "Cantidad";
            this.C3.MinimumWidth = 6;
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 125;
            // 
            // C4
            // 
            this.C4.HeaderText = "Subtotal";
            this.C4.MinimumWidth = 6;
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 125;
            // 
            // SubirBajar_Cantidad
            // 
            this.SubirBajar_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubirBajar_Cantidad.Location = new System.Drawing.Point(217, 286);
            this.SubirBajar_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.SubirBajar_Cantidad.Name = "SubirBajar_Cantidad";
            this.SubirBajar_Cantidad.Size = new System.Drawing.Size(82, 30);
            this.SubirBajar_Cantidad.TabIndex = 30;
            // 
            // CmbNombre
            // 
            this.CmbNombre.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNombre.FormattingEnabled = true;
            this.CmbNombre.Location = new System.Drawing.Point(204, 15);
            this.CmbNombre.Name = "CmbNombre";
            this.CmbNombre.Size = new System.Drawing.Size(189, 29);
            this.CmbNombre.TabIndex = 29;
            this.CmbNombre.SelectedIndexChanged += new System.EventHandler(this.CmbNombre_SelectedIndexChanged);
            // 
            // PbxFoto
            // 
            this.PbxFoto.Location = new System.Drawing.Point(464, 70);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(297, 209);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 28;
            this.PbxFoto.TabStop = false;
            this.PbxFoto.Click += new System.EventHandler(this.PbxFoto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(615, 472);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(615, 422);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 43);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(65, 626);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "......";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "TOTAL A PAGAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.Location = new System.Drawing.Point(213, 211);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(60, 21);
            this.lblEstilo.TabIndex = 14;
            this.lblEstilo.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(213, 250);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 21);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "..........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(213, 169);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(60, 21);
            this.lblMaterial.TabIndex = 12;
            this.lblMaterial.Text = "..........";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Venta:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(213, 123);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(60, 21);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "..........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estilo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(213, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "..........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Material:";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Black;
            this.btnVender.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(218, 20);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(153, 52);
            this.btnVender.TabIndex = 24;
            this.btnVender.Text = "COMPRAR";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnModerno
            // 
            this.btnModerno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnModerno.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModerno.ForeColor = System.Drawing.Color.Black;
            this.btnModerno.Location = new System.Drawing.Point(154, 10);
            this.btnModerno.Name = "btnModerno";
            this.btnModerno.Size = new System.Drawing.Size(126, 48);
            this.btnModerno.TabIndex = 25;
            this.btnModerno.Text = "Moderno";
            this.btnModerno.UseVisualStyleBackColor = false;
            this.btnModerno.Click += new System.EventHandler(this.btnModerno_Click);
            // 
            // btnclasico
            // 
            this.btnclasico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnclasico.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclasico.ForeColor = System.Drawing.Color.Black;
            this.btnclasico.Location = new System.Drawing.Point(10, 11);
            this.btnclasico.Name = "btnclasico";
            this.btnclasico.Size = new System.Drawing.Size(124, 46);
            this.btnclasico.TabIndex = 26;
            this.btnclasico.Text = "Clásico";
            this.btnclasico.UseVisualStyleBackColor = false;
            this.btnclasico.Click += new System.EventHandler(this.btnclasico_Click);
            // 
            // btnRustico
            // 
            this.btnRustico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.btnRustico.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRustico.ForeColor = System.Drawing.Color.Black;
            this.btnRustico.Location = new System.Drawing.Point(301, 11);
            this.btnRustico.Name = "btnRustico";
            this.btnRustico.Size = new System.Drawing.Size(141, 49);
            this.btnRustico.TabIndex = 27;
            this.btnRustico.Text = "Rústico";
            this.btnRustico.UseVisualStyleBackColor = false;
            this.btnRustico.Click += new System.EventHandler(this.btnRustico_Click);
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.BackColor = System.Drawing.Color.Black;
            this.Btn_Reiniciar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reiniciar.ForeColor = System.Drawing.Color.White;
            this.Btn_Reiniciar.Location = new System.Drawing.Point(468, 20);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(261, 52);
            this.Btn_Reiniciar.TabIndex = 28;
            this.Btn_Reiniciar.Text = "NUEVA COMPRA";
            this.Btn_Reiniciar.UseVisualStyleBackColor = false;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.Btn_Reiniciar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnRustico);
            this.panel2.Controls.Add(this.btnModerno);
            this.panel2.Controls.Add(this.btnclasico);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 67);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.Btn_Reiniciar);
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Location = new System.Drawing.Point(0, 771);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 102);
            this.panel3.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(757, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(869, 866);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubirBajar_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Button btnRustico;
        private System.Windows.Forms.Button btnclasico;
        private System.Windows.Forms.Button btnModerno;
        private System.Windows.Forms.ComboBox CmbNombre;
        private System.Windows.Forms.NumericUpDown SubirBajar_Cantidad;
        private System.Windows.Forms.DataGridView Vista_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}