﻿using System;
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
    public partial class cuNotas : UserControl
    {
        frmMenu menu;
        SQLControl con;

        public cuNotas()
        {
            con = new SQLControl();
            InitializeComponent();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            ActualizarNotas();
        }

        public frmMenu Menu { get => menu; set => menu = value; }

        private void ActualizarNotas()
        {
            dgvNotas.DataSource = con.Query("select N.id_nota as Nota,N.fecha_renta as Fecha,N.costo as Costo,U.nombre as Usuario from Nota as N,Usuario as U where N.Id_usuario = U.Id_usuario and fecha_renta between '"+dtpInicio.Value.ToString("yyyy/MM/dd 00:00:00")+"' and '"+dtpFin.Value.ToString("yyyy/MM/dd 23:59:59") + "'");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarNotas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro de eliminar la Nota?", "Confirmar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                con.EliminarNota(dgvNotas.SelectedRows[0].Cells["Nota"].Value.ToString());
                ActualizarNotas();
            }
            
        }

        private void dgvNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Menu.cargarNota(Convert.ToInt32(dgvNotas.SelectedRows[0].Cells["Nota"].Value));
        }
    }
}
