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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.vestidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVestidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVestidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuCrudVestidos1 = new Proyecto_IMPERIO.cuCrudVestidos();
            this.cuPuntoVenta1 = new Proyecto_IMPERIO.cuPuntoVenta();
            this.cuNotas1 = new Proyecto_IMPERIO.cuNotas();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vestidosToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(888, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // vestidosToolStripMenuItem
            // 
            this.vestidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVestidoToolStripMenuItem,
            this.listaDeVestidosToolStripMenuItem});
            this.vestidosToolStripMenuItem.Name = "vestidosToolStripMenuItem";
            this.vestidosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vestidosToolStripMenuItem.Text = "Vestidos";
            // 
            // agregarVestidoToolStripMenuItem
            // 
            this.agregarVestidoToolStripMenuItem.Name = "agregarVestidoToolStripMenuItem";
            this.agregarVestidoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarVestidoToolStripMenuItem.Text = "Agregar Vestido";
            this.agregarVestidoToolStripMenuItem.Click += new System.EventHandler(this.agregarVestidoToolStripMenuItem_Click);
            // 
            // listaDeVestidosToolStripMenuItem
            // 
            this.listaDeVestidosToolStripMenuItem.Name = "listaDeVestidosToolStripMenuItem";
            this.listaDeVestidosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeVestidosToolStripMenuItem.Text = "Inventario";
            this.listaDeVestidosToolStripMenuItem.Click += new System.EventHandler(this.listaDeVestidosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaNotaToolStripMenuItem,
            this.listaDeNotasToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // nuevaNotaToolStripMenuItem
            // 
            this.nuevaNotaToolStripMenuItem.Name = "nuevaNotaToolStripMenuItem";
            this.nuevaNotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaNotaToolStripMenuItem.Text = "Nueva Nota";
            this.nuevaNotaToolStripMenuItem.Click += new System.EventHandler(this.nuevaNotaToolStripMenuItem_Click);
            // 
            // listaDeNotasToolStripMenuItem
            // 
            this.listaDeNotasToolStripMenuItem.Name = "listaDeNotasToolStripMenuItem";
            this.listaDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeNotasToolStripMenuItem.Text = "Lista de Notas";
            this.listaDeNotasToolStripMenuItem.Click += new System.EventHandler(this.listaDeNotasToolStripMenuItem_Click);
            // 
            // cuCrudVestidos1
            // 
            this.cuCrudVestidos1.Location = new System.Drawing.Point(6, 27);
            this.cuCrudVestidos1.Name = "cuCrudVestidos1";
            this.cuCrudVestidos1.Size = new System.Drawing.Size(870, 485);
            this.cuCrudVestidos1.TabIndex = 1;
            // 
            // cuPuntoVenta1
            // 
            this.cuPuntoVenta1.Location = new System.Drawing.Point(6, 27);
            this.cuPuntoVenta1.Name = "cuPuntoVenta1";
            this.cuPuntoVenta1.Size = new System.Drawing.Size(870, 485);
            this.cuPuntoVenta1.TabIndex = 1;
            // 
            // cuNotas1
            // 
            this.cuNotas1.Location = new System.Drawing.Point(6, 27);
            this.cuNotas1.Name = "cuNotas1";
            this.cuNotas1.Size = new System.Drawing.Size(870, 485);
            this.cuNotas1.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.cuNotas1);
            this.Controls.Add(this.cuCrudVestidos1);
            this.Controls.Add(this.cuPuntoVenta1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imperio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem vestidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVestidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVestidosToolStripMenuItem;
        private cuCrudVestidos cuCrudVestidos1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNotasToolStripMenuItem;
        private cuPuntoVenta cuPuntoVenta1;
        private cuNotas cuNotas1;
    }
}