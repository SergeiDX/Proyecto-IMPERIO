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
            this.cuCrudVestidos1 = new Proyecto_IMPERIO.cuCrudVestidos();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vestidosToolStripMenuItem});
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
            this.agregarVestidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarVestidoToolStripMenuItem.Text = "Agregar Vestido";
            this.agregarVestidoToolStripMenuItem.Click += new System.EventHandler(this.agregarVestidoToolStripMenuItem_Click);
            // 
            // listaDeVestidosToolStripMenuItem
            // 
            this.listaDeVestidosToolStripMenuItem.Name = "listaDeVestidosToolStripMenuItem";
            this.listaDeVestidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeVestidosToolStripMenuItem.Text = "Lista de Vestidos";
            this.listaDeVestidosToolStripMenuItem.Click += new System.EventHandler(this.listaDeVestidosToolStripMenuItem_Click);
            // 
            // cuCrudVestidos1
            // 
            this.cuCrudVestidos1.Location = new System.Drawing.Point(12, 27);
            this.cuCrudVestidos1.Name = "cuCrudVestidos1";
            this.cuCrudVestidos1.Size = new System.Drawing.Size(870, 485);
            this.cuCrudVestidos1.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 514);
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
    }
}