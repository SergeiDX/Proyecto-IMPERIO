using System;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            cuPuntoVenta1.BringToFront();
        }

        private void listaDeVestidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            cuPuntoVenta1.BringToFront();
        }
    }
}
