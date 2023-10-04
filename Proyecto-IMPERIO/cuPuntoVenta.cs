using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Proyecto_IMPERIO
{
    public partial class cuPuntoVenta : UserControl
    {
        SQLControl con;
        private DataTable dt;

        public cuPuntoVenta()
        {
            con = new SQLControl();
            InitializeComponent();
        }

        private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt = con.Query("select Id_vestido as id, Descripcion,Precio,Imagen from Vestidos where Id_vestido =" + tbCodigo.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvVestidos.Rows.Add(dt.Rows[0]["id"], dt.Rows[0]["Descripcion"], dt.Rows[0]["Precio"], dt.Rows[0]["Imagen"]);
                    tbCodigo.Text = "";
                    dt = null;
                }

            }
        }

        private void dgvVestidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVestidos.Rows.Count != 0)
            {
                if (e.ColumnIndex == 4)
                {
                    dgvVestidos.Rows.Remove(dgvVestidos.SelectedRows[0]);
                    pbVestido.Image = null;
                }
                else
                    pbVestido.ImageLocation = dgvVestidos.SelectedRows[0].Cells["Imagen"].Value.ToString();
            }
        }

        private decimal calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in dgvVestidos.Rows)
            {
                total += Convert.ToDecimal(r.Cells["Costo"].Value);
            }
            return total;
        }

        private void dgvVestidos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tbImporte.Text = (calcularTotal() - ((calcularTotal() * nudDescuento.Value) / 100)).ToString();

        }

        private void dgvVestidos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tbImporte.Text = (calcularTotal() - ((calcularTotal() * nudDescuento.Value) / 100)).ToString();
        }

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            tbImporte.Text = (calcularTotal() - ((calcularTotal() * nudDescuento.Value) / 100)).ToString();
        }

        private void tbImporte_TextChanged(object sender, EventArgs e)
        {
            tbResto.Text = (Convert.ToDouble(tbImporte.Text) - Convert.ToDouble(tbAnticipo.Text)).ToString();
        }

        private void tbAnticipo_TextChanged(object sender, EventArgs e)
        {
            if(tbAnticipo.Text!="")
                tbResto.Text = (Convert.ToDouble(tbImporte.Text) - Convert.ToDouble(tbAnticipo.Text)).ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            printDocument1.PrinterSettings = new PrinterSettings();
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

            /*if (dgvVestidos.Rows.Count != 0)
            {
                con.RegistrarNota(tbCliente.Text, tbTelefono.Text, nudDescuento.Value, DateTime.Now, dtpFecha.Value, tbImporte.Text, tbAnticipo.Text, tbResto.Text, 1, dgvVestidos.Rows);
                while(dgvVestidos.RowCount != 0)
                    dgvVestidos.Rows.RemoveAt(0);
                tbAnticipo.Text = "0";
                nudDescuento.Value = 0;
                tbCliente.Text = "";
                tbTelefono.Text = "";
                dtpFecha.Value = DateTime.Now;
            }*/
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            string costo = dgvVestidos.SelectedRows[0].Cells["Costo"].Value.ToString();
            // int aa = (int)Convert.ToInt32(tbTotal.Text);

          

            // int resultadoDescuento = Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbImporte.Text);
            // int resultadoDescuento = int.Parse(tbTotal.Text) - int.Parse(tbImporte.Text);

            Font font = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 5, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);


            int width = 380;
            int y = 20;
            e.Graphics.DrawString("         RENTA DE VESTIDOS IMPERIO", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

            e.Graphics.DrawString("                     V. Carranza #146 Zona Centro Monclova CP 25700", font2, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("Usuario: ZZZZZZ               Fecha: "+DateTime.Now, font3, Brushes.Black, new Rectangle(0, y += 20, width, 20));
    
            e.Graphics.DrawString("=================================================", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

            e.Graphics.DrawString("    Cliente: " + tbCliente.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Telefono: " + tbTelefono.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Total: $" + tbImporte.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Fecha de renta: " + dtpFecha.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Fecha de evento: " + "FechaPendiente", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Costo vestido: $" + costo, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Anticipo: $" + tbAnticipo.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("    Resto: $" + tbResto.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

            e.Graphics.DrawString("=================================================", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("¡Gracias por su preferencia vuelva pronto!", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

        }
    }
}
