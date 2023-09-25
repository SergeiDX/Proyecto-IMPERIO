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
            this.dgvVestidos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pNota = new System.Windows.Forms.Panel();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVestidos)).BeginInit();
            this.pNota.SuspendLayout();
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
            this.dgvVestidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVestidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Imagen,
            this.Eliminar});
            this.dgvVestidos.Location = new System.Drawing.Point(9, 67);
            this.dgvVestidos.MultiSelect = false;
            this.dgvVestidos.Name = "dgvVestidos";
            this.dgvVestidos.ReadOnly = true;
            this.dgvVestidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVestidos.Size = new System.Drawing.Size(645, 385);
            this.dgvVestidos.TabIndex = 6;
            this.dgvVestidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVestidos_CellClick);
            this.dgvVestidos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVestidos_RowsAdded);
            this.dgvVestidos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvVestidos_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 30F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 111.9289F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.FillWeight = 25F;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // pNota
            // 
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
            this.pNota.Location = new System.Drawing.Point(654, 0);
            this.pNota.Name = "pNota";
            this.pNota.Size = new System.Drawing.Size(216, 485);
            this.pNota.TabIndex = 15;
            // 
            // tbResto
            // 
            this.tbResto.Enabled = false;
            this.tbResto.Location = new System.Drawing.Point(69, 410);
            this.tbResto.Name = "tbResto";
            this.tbResto.Size = new System.Drawing.Size(81, 20);
            this.tbResto.TabIndex = 15;
            this.tbResto.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Resto";
            // 
            // tbAnticipo
            // 
            this.tbAnticipo.Location = new System.Drawing.Point(68, 384);
            this.tbAnticipo.Name = "tbAnticipo";
            this.tbAnticipo.Size = new System.Drawing.Size(82, 20);
            this.tbAnticipo.TabIndex = 13;
            this.tbAnticipo.Text = "0";
            this.tbAnticipo.TextChanged += new System.EventHandler(this.tbAnticipo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Anticipo";
            // 
            // tbImporte
            // 
            this.tbImporte.Enabled = false;
            this.tbImporte.Location = new System.Drawing.Point(68, 358);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(82, 20);
            this.tbImporte.TabIndex = 11;
            this.tbImporte.Text = "0";
            this.tbImporte.TextChanged += new System.EventHandler(this.tbImporte_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Importe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "%";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(69, 333);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(47, 20);
            this.nudDescuento.TabIndex = 8;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(68, 260);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(82, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(68, 234);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(68, 197);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(145, 20);
            this.tbCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cliente";
            // 
            // pbVestido
            // 
            this.pbVestido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVestido.Location = new System.Drawing.Point(36, 14);
            this.pbVestido.Name = "pbVestido";
            this.pbVestido.Size = new System.Drawing.Size(140, 148);
            this.pbVestido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVestido.TabIndex = 0;
            this.pbVestido.TabStop = false;
            // 
            // pArticulo
            // 
            this.pArticulo.Controls.Add(this.btnBuscar);
            this.pArticulo.Controls.Add(this.tbCodigo);
            this.pArticulo.Controls.Add(this.label1);
            this.pArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pArticulo.Location = new System.Drawing.Point(0, 0);
            this.pArticulo.Name = "pArticulo";
            this.pArticulo.Size = new System.Drawing.Size(654, 61);
            this.pArticulo.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(384, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(220, 14);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(158, 22);
            this.tbCodigo.TabIndex = 16;
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(578, 458);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(70, 20);
            this.tbTotal.TabIndex = 18;
            this.tbTotal.Text = "0";
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(69, 436);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(81, 42);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // cuPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pArticulo);
            this.Controls.Add(this.pNota);
            this.Controls.Add(this.dgvVestidos);
            this.Name = "cuPuntoVenta";
            this.Size = new System.Drawing.Size(870, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVestidos)).EndInit();
            this.pNota.ResumeLayout(false);
            this.pNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVestido)).EndInit();
            this.pArticulo.ResumeLayout(false);
            this.pArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVestidos;
        private System.Windows.Forms.Panel pNota;
        private System.Windows.Forms.PictureBox pbVestido;
        private System.Windows.Forms.Panel pArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
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
    }
}
