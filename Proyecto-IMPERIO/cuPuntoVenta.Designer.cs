namespace Proyecto_IMPERIO
{
    partial class cuPuntoVenta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuPuntoVenta));
            this.dgvVestidos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pNota = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tbResto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAnticipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbVestido = new System.Windows.Forms.PictureBox();
            this.pArticulo = new System.Windows.Forms.Panel();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVestidos)).BeginInit();
            this.pNota.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVestido)).BeginInit();
            this.pArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVestidos
            // 
            this.dgvVestidos.AllowUserToAddRows = false;
            this.dgvVestidos.AllowUserToDeleteRows = false;
            this.dgvVestidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVestidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVestidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVestidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Imagen,
            this.Eliminar});
            this.dgvVestidos.Location = new System.Drawing.Point(12, 83);
            this.dgvVestidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVestidos.MultiSelect = false;
            this.dgvVestidos.Name = "dgvVestidos";
            this.dgvVestidos.ReadOnly = true;
            this.dgvVestidos.RowHeadersWidth = 51;
            this.dgvVestidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVestidos.Size = new System.Drawing.Size(860, 627);
            this.dgvVestidos.TabIndex = 6;
            this.dgvVestidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVestidos_CellClick);
            this.dgvVestidos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVestidos_RowsAdded);
            this.dgvVestidos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvVestidos_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 30F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 111.9289F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.FillWeight = 25F;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // pNota
            // 
            this.pNota.BackColor = System.Drawing.Color.White;
            this.pNota.Controls.Add(this.panel3);
            this.pNota.Controls.Add(this.btnPagar);
            this.pNota.Controls.Add(this.tbResto);
            this.pNota.Controls.Add(this.label10);
            this.pNota.Controls.Add(this.tbAnticipo);
            this.pNota.Controls.Add(this.label9);
            this.pNota.Controls.Add(this.tbImporte);
            this.pNota.Controls.Add(this.label8);
            this.pNota.Controls.Add(this.label7);
            this.pNota.Controls.Add(this.nudDescuento);
            this.pNota.Controls.Add(this.label3);
            this.pNota.Controls.Add(this.dtpFecha);
            this.pNota.Controls.Add(this.label6);
            this.pNota.Controls.Add(this.tbTelefono);
            this.pNota.Controls.Add(this.label5);
            this.pNota.Controls.Add(this.tbCliente);
            this.pNota.Controls.Add(this.label4);
            this.pNota.Controls.Add(this.pbVestido);
            this.pNota.Dock = System.Windows.Forms.DockStyle.Right;
            this.pNota.Location = new System.Drawing.Point(872, 0);
            this.pNota.Margin = new System.Windows.Forms.Padding(4);
            this.pNota.Name = "pNota";
            this.pNota.Size = new System.Drawing.Size(288, 714);
            this.pNota.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 60);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Black;
            this.btnPagar.Font = new System.Drawing.Font("Typewriter_Condensed_Demi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(101, 635);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(108, 52);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // tbResto
            // 
            this.tbResto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResto.Enabled = false;
            this.tbResto.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResto.Location = new System.Drawing.Point(113, 567);
            this.tbResto.Margin = new System.Windows.Forms.Padding(4);
            this.tbResto.Name = "tbResto";
            this.tbResto.Size = new System.Drawing.Size(107, 34);
            this.tbResto.TabIndex = 15;
            this.tbResto.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 580);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Resto";
            // 
            // tbAnticipo
            // 
            this.tbAnticipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnticipo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnticipo.Location = new System.Drawing.Point(113, 515);
            this.tbAnticipo.Margin = new System.Windows.Forms.Padding(4);
            this.tbAnticipo.Name = "tbAnticipo";
            this.tbAnticipo.Size = new System.Drawing.Size(108, 34);
            this.tbAnticipo.TabIndex = 13;
            this.tbAnticipo.Text = "0";
            this.tbAnticipo.TextChanged += new System.EventHandler(this.tbAnticipo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Anticipo";
            // 
            // tbImporte
            // 
            this.tbImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbImporte.Enabled = false;
            this.tbImporte.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporte.Location = new System.Drawing.Point(113, 465);
            this.tbImporte.Margin = new System.Windows.Forms.Padding(4);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(108, 34);
            this.tbImporte.TabIndex = 11;
            this.tbImporte.Text = "0";
            this.tbImporte.TextChanged += new System.EventHandler(this.tbImporte_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 478);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "%";
            // 
            // nudDescuento
            // 
            this.nudDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDescuento.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDescuento.Location = new System.Drawing.Point(113, 420);
            this.nudDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(63, 34);
            this.nudDescuento.TabIndex = 8;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 429);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(113, 364);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(166, 34);
            this.dtpFecha.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefono.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(113, 310);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(166, 34);
            this.tbTelefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // tbCliente
            // 
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCliente.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(113, 266);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(166, 34);
            this.tbCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cliente";
            // 
            // pbVestido
            // 
            this.pbVestido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVestido.Location = new System.Drawing.Point(51, 70);
            this.pbVestido.Margin = new System.Windows.Forms.Padding(4);
            this.pbVestido.Name = "pbVestido";
            this.pbVestido.Size = new System.Drawing.Size(186, 182);
            this.pbVestido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVestido.TabIndex = 0;
            this.pbVestido.TabStop = false;
            // 
            // pArticulo
            // 
            this.pArticulo.BackColor = System.Drawing.Color.White;
            this.pArticulo.Controls.Add(this.tbCodigo);
            this.pArticulo.Controls.Add(this.label1);
            this.pArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pArticulo.Location = new System.Drawing.Point(0, 0);
            this.pArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pArticulo.Name = "pArticulo";
            this.pArticulo.Size = new System.Drawing.Size(872, 75);
            this.pArticulo.TabIndex = 16;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(293, 13);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(209, 34);
            this.tbCodigo.TabIndex = 16;
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // cuPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pArticulo);
            this.Controls.Add(this.pNota);
            this.Controls.Add(this.dgvVestidos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cuPuntoVenta";
            this.Size = new System.Drawing.Size(1160, 714);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVestidos)).EndInit();
            this.pNota.ResumeLayout(false);
            this.pNota.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVestido)).EndInit();
            this.pArticulo.ResumeLayout(false);
            this.pArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVestidos;
        private System.Windows.Forms.Panel pNota;
        private System.Windows.Forms.PictureBox pbVestido;
        private System.Windows.Forms.Panel pArticulo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox tbResto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAnticipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
