using System;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmFechaEntrega : Form
    {
        private cuEntregas padre;
        private SQLControl cone;
        private string vestido;
        private string nota;
        public frmFechaEntrega(cuEntregas padre,string vestido, string nota)
        {
            cone = new SQLControl();
            this.vestido = vestido;
            this.nota = nota;
            this.padre = padre;
            InitializeComponent();
            dtpFecha.Value = DateTime.Now;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cone.ActualizarGenera(dtpFecha.Value, vestido, nota);
            padre.cargarDatos();
            Close();
        }
    }
}
