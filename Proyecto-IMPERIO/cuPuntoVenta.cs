using System;
using System.Drawing;
using System.Data;
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

        public cuPuntoVenta(int nota)
        {
            con = new SQLControl();
            InitializeComponent();
            DataTable datos = con.Query("select v.Id_vestido as id, v.descripcion,v.precio,v.imagen from genera as g, vestidos as v where g.Id_nota="+nota.ToString()+" and g.id_vestido = v.Id_vestido");
            foreach(DataRow fila in datos.Rows)
            {
                dgvVestidos.Rows.Add(fila[0], fila[1], fila[2], fila[3]);
            }
            dgvVestidos.Columns[4].Visible = false;

            datos = con.Query("select Nombre_Cliente as nombre, telefono as num, descuento,fecha_evento as fecha,anticipo from nota where id_nota = "+nota.ToString());
            tbAnticipo.Text = datos.Rows[0]["anticipo"].ToString();
            tbAnticipo.Enabled = false;
            tbCliente.Text = datos.Rows[0]["nombre"].ToString();
            tbCliente.Enabled = false;
            tbCodigo.Enabled = false;
            tbTelefono.Text = datos.Rows[0]["num"].ToString();
            tbTelefono.Enabled = false;
            nudDescuento.Value = Convert.ToInt32(datos.Rows[0]["descuento"]);
            nudDescuento.Enabled = false;
            dtpFecha.Value = (DateTime)datos.Rows[0]["fecha"];
            dtpFecha.Enabled = false;
            btnPagar.Text = "Imprimir";
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
            bool ocupado = false;
            foreach(DataGridViewRow fila in dgvVestidos.Rows)
            {
                string vestido = fila.Cells[0].Value.ToString();

                string diasemana = dtpFecha.Value.DayOfWeek.ToString();
                int diferencia1 = 0;
                int diferencia2 = 6;
                switch (diasemana)
                {
                    case "Monday":
                        diferencia1 = -1;
                        diferencia2 = 5;
                        break;

                    case "Tuesday":
                        diferencia1 = -2;
                        diferencia2 = 4;
                        break;

                    case "Wednesday":
                        diferencia1 = -3;
                        diferencia2 = 3;
                        break;

                    case "Thursday":
                        diferencia1 = -4;
                        diferencia2 = 2;
                        break;

                    case "Friday":
                        diferencia1 = -5;
                        diferencia2 = 1;
                        break;

                    case "Saturday":
                        diferencia1 = -6;
                        diferencia2 = 0;
                        break;
                }
                DateTime fInicio = dtpFecha.Value.AddDays(diferencia1);
                DateTime fFin = dtpFecha.Value.AddDays(diferencia2);


                if (con.Query("select n.Id_nota from nota as n, Genera as g where n.Id_nota=g.Id_nota and g.Id_vestido = " + vestido + "and n.fecha_evento between '" + fInicio.ToString("yyyy/MM/dd 00:00:00") + "' and '" + fFin.ToString("yyyy/MM/dd 23:59:59") + "'").Rows.Count !=0)
                {
                    ocupado = true;
                    MessageBox.Show("El vestido " + fila.Cells[1].Value.ToString() + " esta rentado en esa semana");
                    break;
                }
            }

            if (dgvVestidos.Rows.Count != 0 && !ocupado)
            {
                printDocument1 = new PrintDocument();
                printDocument1.PrinterSettings = new PrinterSettings();
                printDocument1.PrintPage += Imprimir;
                printDocument1.Print();

                if(btnPagar.Text != "Imprimir")
                {
                    con.RegistrarNota(tbCliente.Text, tbTelefono.Text, nudDescuento.Value, DateTime.Now, dtpFecha.Value, tbImporte.Text, tbAnticipo.Text, tbResto.Text, 1, dgvVestidos.Rows);
                    while (dgvVestidos.RowCount != 0)
                        dgvVestidos.Rows.RemoveAt(0);
                    tbAnticipo.Text = "0";
                    nudDescuento.Value = 0;
                    tbCliente.Text = "";
                    tbTelefono.Text = "";
                    dtpFecha.Value = DateTime.Now;
                }
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            
            
            // int aa = (int)Convert.ToInt32(tbTotal.Text);


            /*OpenFileDialog ofd = new OpenFileDialog();
            string foto = ofd.FileName;
            foto = "imagenes/Vestido.png";
             int resultadoDescuento = Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbImporte.Text);
             int resultadoDescuento = int.Parse(tbTotal.Text) - int.Parse(tbImporte.Text);*/
            Font font = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);
            Font font4 = new Font("Tw Cen MT", 13, FontStyle.Bold, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);




            /*Image newImage = Image.FromFile(foto);
            float x = 5.0F;
            float y2 = 5.0F;
            float width2 = 250.0F;
            float height = 125.0F;
            e.Graphics.DrawImage(image:newImage,x,y2,width2,height);
            e.Graphics.DrawString("  ", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("  ", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("  ", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("  ", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("  ", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));*/

            
           





            
            int width = 380;
            int y = 20;
            //TITULO
            e.Graphics.DrawString("  RENTA DE VESTIDOS IMPERIO", font4, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            e.Graphics.DrawString("              V. Carranza #146 Zona Centro Monclova CP 25700", font2, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            
            e.Graphics.DrawString("Usuario: "+Properties.Settings.Default.usuario+ "\t\t\t" + DateTime.Now, font3, Brushes.Black, new Rectangle(0, y += 20, width, 20));

                //SEPARADOR
                e.Graphics.DrawString("=================================================", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

                //BODY
                e.Graphics.DrawString("    Cliente: " + tbCliente.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("    Telefono: " + tbTelefono.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("    Fecha de evento: " + dtpFecha.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

                e.Graphics.DrawString("=================================================", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("    Descripcion"+"\t\tCosto", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

            //CARRITO COMPRA
            foreach (DataGridViewRow dgvrenglon in dgvVestidos.Rows)
                {
                    
                    string NombreVestido = dgvrenglon.Cells["Descripcion"].Value.ToString();
                    string CostoVestido = dgvrenglon.Cells["Costo"].Value.ToString();
                 //string output = ("    "+NombreVestido+"\t   $"+CostoVestido);
                    
                    
                    
                    e.Graphics.DrawString("    " + NombreVestido + "\t\t$" + CostoVestido, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            

                }

                e.Graphics.DrawString("    Subtotal: $" + tbImporte.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("    Anticipo: $" + tbAnticipo.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("    Total a pagar: $" + tbResto.Text, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                                
                //SEPARADOR
                e.Graphics.DrawString("=================================================", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("  ¡Gracias por su preferencia vuelva pronto!", font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
            

        }
    }
}
