using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class cuCrudVestidos : UserControl
    {
        SQLControl cone; 

        public cuCrudVestidos()
        {
            cone = new SQLControl();
            InitializeComponent();
            LlenarVestidos();
        }

        public void LlenarVestidos()
        {
            dgvVestidos.DataSource = cone.Query("select * from Vestidos");
            tbBuscar.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmVestido vestido = new frmVestido(this);
            vestido.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmVestido vestido = new frmVestido(this,dgvVestidos.SelectedRows[0].Cells[0].Value.ToString());
            vestido.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro de eliminar el Vestido?", "Confirmar", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                cone.EliminarVestido(dgvVestidos.SelectedRows[0].Cells[0].Value.ToString());
                LlenarVestidos();
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.TextLength != 0)
                dgvVestidos.DataSource = cone.Query("select * from Vestidos where Id_vestido like '%" + tbBuscar.Text + "%' or Descripcion like '%" + tbBuscar.Text + "%'");
            else
                LlenarVestidos();
        }
    }
}
