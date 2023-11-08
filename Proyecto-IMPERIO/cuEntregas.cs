using System;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class cuEntregas : UserControl
    {
        SQLControl cone;

        public cuEntregas()
        {
            cone = new SQLControl();
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            dgvEntregas.DataSource = null;
            dgvEntregas.Columns.Clear();
            dgvEntregas.DataSource = cone.Query("select g.Id_vestido as 'Codigo del vestido',v.descripcion as Vestido,g.Id_nota as Nota, dia_entrega as 'Dia de entrega' from genera as g,vestidos as v where g.Id_vestido = v.Id_vestido and g.dia_entrega between '" + dtpInicio.Value.ToString("yyyy/MM/dd 00:00:00") + "' and '" + dtpFin.Value.ToString("yyyy/MM/dd 23:59:59") + "'");
            DataGridViewButtonColumn Actualizar = new DataGridViewButtonColumn();
            Actualizar.Text = "Cambiar Fecha";
            Actualizar.UseColumnTextForButtonValue = true;
            dgvEntregas.Columns.Add(Actualizar);
        }

        private void dgvEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                frmFechaEntrega fecha = new frmFechaEntrega(this,dgvEntregas.SelectedRows[0].Cells[0].Value.ToString(), dgvEntregas.SelectedRows[0].Cells[2].Value.ToString());
                fecha.Visible = true;
            }
        }
    }
}
