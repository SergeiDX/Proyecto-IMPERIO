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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuCalendario1 = new Proyecto_IMPERIO.cuCalendario();
            this.cuNotas1 = new Proyecto_IMPERIO.cuNotas();
            this.cuCrudVestidos1 = new Proyecto_IMPERIO.cuCrudVestidos();
            this.cuEntregas1 = new Proyecto_IMPERIO.cuEntregas();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vestidosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.consultasToolStripMenuItem});
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
            this.nuevaNotaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevaNotaToolStripMenuItem.Text = "Nueva Nota";
            this.nuevaNotaToolStripMenuItem.Click += new System.EventHandler(this.nuevaNotaToolStripMenuItem_Click);
            // 
            // listaDeNotasToolStripMenuItem
            // 
            this.listaDeNotasToolStripMenuItem.Name = "listaDeNotasToolStripMenuItem";
            this.listaDeNotasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listaDeNotasToolStripMenuItem.Text = "Lista de Notas";
            this.listaDeNotasToolStripMenuItem.Click += new System.EventHandler(this.listaDeNotasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.entregasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entregasToolStripMenuItem.Text = "Entregas";
            this.entregasToolStripMenuItem.Click += new System.EventHandler(this.entregasToolStripMenuItem_Click);
            // 
            // cuCalendario1
            // 
            this.cuCalendario1.Location = new System.Drawing.Point(6, 27);
            this.cuCalendario1.Name = "cuCalendario1";
            this.cuCalendario1.Size = new System.Drawing.Size(870, 580);
            this.cuCalendario1.TabIndex = 3;
            // 
            // cuNotas1
            // 
            this.cuNotas1.Location = new System.Drawing.Point(6, 27);
            this.cuNotas1.Menu = null;
            this.cuNotas1.Name = "cuNotas1";
            this.cuNotas1.Size = new System.Drawing.Size(870, 580);
            this.cuNotas1.TabIndex = 2;
            // 
            // cuCrudVestidos1
            // 
            this.cuCrudVestidos1.Location = new System.Drawing.Point(6, 27);
            this.cuCrudVestidos1.Name = "cuCrudVestidos1";
            this.cuCrudVestidos1.Size = new System.Drawing.Size(870, 580);
            this.cuCrudVestidos1.TabIndex = 1;
            // 
            // cuEntregas1
            // 
            this.cuEntregas1.Location = new System.Drawing.Point(6, 27);
            this.cuEntregas1.Name = "cuEntregas1";
            this.cuEntregas1.Size = new System.Drawing.Size(870, 580);
            this.cuEntregas1.TabIndex = 4;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 609);
            this.Controls.Add(this.cuEntregas1);
            this.Controls.Add(this.cuCalendario1);
            this.Controls.Add(this.cuNotas1);
            this.Controls.Add(this.cuCrudVestidos1);
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
        private cuNotas cuNotas1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private cuCalendario cuCalendario1;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private cuEntregas cuEntregas1;
    }
}