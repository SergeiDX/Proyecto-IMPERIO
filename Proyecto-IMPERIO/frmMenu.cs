using System;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmMenu : Form
    {
        cuPuntoVenta puntoVenta;
        public frmMenu()
        {
            InitializeComponent();
            nuevaNota();
            cuNotas1.Menu = this;
        }

        private void listaDeVestidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(puntoVenta);
            cuCrudVestidos1.BringToFront();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void agregarVestidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVestido vestido = new frmVestido(cuCrudVestidos1);
            vestido.Show();
        }

        private void nuevaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevaNota();
        }

        private void listaDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(puntoVenta);
            cuNotas1.BringToFront();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(puntoVenta);
            cuCalendario1.BringToFront();
        }

        private void nuevaNota()
        {
            puntoVenta = new cuPuntoVenta();
            puntoVenta.Location = new System.Drawing.Point(6, 27);
            Controls.Add(puntoVenta);
            Controls[Controls.IndexOf(puntoVenta)].BringToFront();
        }

        public void cargarNota(int nota)
        {
            puntoVenta = new cuPuntoVenta(nota);
            puntoVenta.Location = new System.Drawing.Point(6, 27);
            Controls.Add(puntoVenta);
            Controls[Controls.IndexOf(puntoVenta)].BringToFront();
        }
    }
}
