namespace Proyecto_IMPERIO
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
			this.vestidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarVestidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeVestidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.cuNotas2 = new Proyecto_IMPERIO.cuNotas();
			this.cuEntregas1 = new Proyecto_IMPERIO.cuEntregas();
			this.cuCalendario1 = new Proyecto_IMPERIO.cuCalendario();
			this.cuCrudVestidos2 = new Proyecto_IMPERIO.cuCrudVestidos();
			this.msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// vestidosToolStripMenuItem
			// 
			this.vestidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVestidoToolStripMenuItem,
            this.listaDeVestidosToolStripMenuItem});
			this.vestidosToolStripMenuItem.Name = "vestidosToolStripMenuItem";
			this.vestidosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
			this.vestidosToolStripMenuItem.Text = "VESTIDOS";
			// 
			// agregarVestidoToolStripMenuItem
			// 
			this.agregarVestidoToolStripMenuItem.Name = "agregarVestidoToolStripMenuItem";
			this.agregarVestidoToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
			this.agregarVestidoToolStripMenuItem.Text = "AGREGAR VESTIDO";
			this.agregarVestidoToolStripMenuItem.Click += new System.EventHandler(this.agregarVestidoToolStripMenuItem_Click);
			// 
			// listaDeVestidosToolStripMenuItem
			// 
			this.listaDeVestidosToolStripMenuItem.Name = "listaDeVestidosToolStripMenuItem";
			this.listaDeVestidosToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
			this.listaDeVestidosToolStripMenuItem.Text = "INVENTARIO";
			this.listaDeVestidosToolStripMenuItem.Click += new System.EventHandler(this.listaDeVestidosToolStripMenuItem_Click);
			// 
			// notasToolStripMenuItem
			// 
			this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaNotaToolStripMenuItem,
            this.listaDeNotasToolStripMenuItem});
			this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
			this.notasToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.notasToolStripMenuItem.Text = "NOTAS";
			// 
			// nuevaNotaToolStripMenuItem
			// 
			this.nuevaNotaToolStripMenuItem.Name = "nuevaNotaToolStripMenuItem";
			this.nuevaNotaToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
			this.nuevaNotaToolStripMenuItem.Text = "NUEVA NOTA";
			this.nuevaNotaToolStripMenuItem.Click += new System.EventHandler(this.nuevaNotaToolStripMenuItem_Click);
			// 
			// listaDeNotasToolStripMenuItem
			// 
			this.listaDeNotasToolStripMenuItem.Name = "listaDeNotasToolStripMenuItem";
			this.listaDeNotasToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
			this.listaDeNotasToolStripMenuItem.Text = "LISTA DE NOTAS";
			this.listaDeNotasToolStripMenuItem.Click += new System.EventHandler(this.listaDeNotasToolStripMenuItem_Click);
			// 
			// consultasToolStripMenuItem
			// 
			this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.entregasToolStripMenuItem});
			this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
			this.consultasToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
			this.consultasToolStripMenuItem.Text = "CONSULTAS";
			// 
			// calendarioToolStripMenuItem
			// 
			this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
			this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
			this.calendarioToolStripMenuItem.Text = "CALENDARIO";
			this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
			// 
			// entregasToolStripMenuItem
			// 
			this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
			this.entregasToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
			this.entregasToolStripMenuItem.Text = "ENTREGAS";
			this.entregasToolStripMenuItem.Click += new System.EventHandler(this.entregasToolStripMenuItem_Click);
			// 
			// msMenu
			// 
			this.msMenu.BackColor = System.Drawing.Color.White;
			this.msMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vestidosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.consultasToolStripMenuItem});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.msMenu.Size = new System.Drawing.Size(888, 28);
			this.msMenu.TabIndex = 0;
			this.msMenu.Text = "menuStrip1";
			// 
			// cuNotas2
			// 
			this.cuNotas2.BackColor = System.Drawing.Color.White;
			this.cuNotas2.Location = new System.Drawing.Point(10, 26);
			this.cuNotas2.Menu = null;
			this.cuNotas2.Name = "cuNotas2";
			this.cuNotas2.Size = new System.Drawing.Size(882, 580);
			this.cuNotas2.TabIndex = 5;
			// 
			// cuEntregas1
			// 
			this.cuEntregas1.BackColor = System.Drawing.Color.White;
			this.cuEntregas1.Location = new System.Drawing.Point(12, 27);
			this.cuEntregas1.Margin = new System.Windows.Forms.Padding(4);
			this.cuEntregas1.Name = "cuEntregas1";
			this.cuEntregas1.Size = new System.Drawing.Size(874, 579);
			this.cuEntregas1.TabIndex = 4;
			// 
			// cuCalendario1
			// 
			this.cuCalendario1.BackColor = System.Drawing.Color.White;
			this.cuCalendario1.Location = new System.Drawing.Point(12, 28);
			this.cuCalendario1.Margin = new System.Windows.Forms.Padding(4);
			this.cuCalendario1.Name = "cuCalendario1";
			this.cuCalendario1.Size = new System.Drawing.Size(876, 578);
			this.cuCalendario1.TabIndex = 3;
			// 
			// cuCrudVestidos2
			// 
			this.cuCrudVestidos2.BackColor = System.Drawing.Color.White;
			this.cuCrudVestidos2.Location = new System.Drawing.Point(12, 28);
			this.cuCrudVestidos2.Name = "cuCrudVestidos2";
			this.cuCrudVestidos2.Size = new System.Drawing.Size(870, 580);
			this.cuCrudVestidos2.TabIndex = 6;
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(888, 609);
			this.Controls.Add(this.cuNotas2);
			this.Controls.Add(this.msMenu);
			this.Controls.Add(this.cuEntregas1);
			this.Controls.Add(this.cuCalendario1);
			this.Controls.Add(this.cuCrudVestidos2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.msMenu;
			this.MaximizeBox = false;
			this.Name = "frmMenu";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Imperio";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
			this.Load += new System.EventHandler(this.frmMenu_Load);
			this.msMenu.ResumeLayout(false);
			this.msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private cuCrudVestidos cuCrudVestidos;
        private cuNotas cuNotas1;
        private cuCalendario cuCalendario1;
        private cuEntregas cuEntregas1;
        private System.Windows.Forms.ToolStripMenuItem vestidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVestidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVestidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenu;
        private cuNotas cuNotas2;
        private cuCrudVestidos cuCrudVestidos2;
    }
}