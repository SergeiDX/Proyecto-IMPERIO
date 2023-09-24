using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmVenta : Form
    {
        SQLControl sQLControl = new SQLControl();
        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            sQLControl.cnn.Open();
            string cadena = "select Nombre_Cliente,telefono,descuento,fecha_renta,fecha_evento,costo,anticipo,resto from Nota where Id_nota=1";
            SqlCommand cmd = new SqlCommand(cadena,sQLControl.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                
                DateTime fechaRenta = (DateTime)dr["fecha_renta"];
                string fecha1 = fechaRenta.ToString("");
                DateTime fechaEvent = (DateTime)dr["fecha_evento"];
                string fecha2= fechaEvent.ToString("");
                
                decimal descuento = (decimal)dr["descuento"];
                double descuuento = (double)descuento;

                decimal costo = (decimal)dr["costo"];
                double coosto = (double)costo;

                decimal anticipo = (decimal)dr["anticipo"];
                double antiicipo = (double)anticipo;

                decimal resto = (decimal)dr["resto"];
                double reesto = (double)resto;


                Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
                int width = 380;
                int y = 20;
                e.Graphics.DrawString("Cliente: "+dr["Nombre_Cliente"].ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Telefono: "+dr["telefono"].ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Descuento: $"+descuuento.ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Fecha de renta: "+fecha1, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Fecha de evento: "+fecha2, font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Costo vestido: $"+coosto.ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Anticipo: $"+antiicipo.ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));
                e.Graphics.DrawString("Resto: $"+reesto.ToString(), font, Brushes.Black, new Rectangle(0, y += 20, width, 20));

            }
            sQLControl.cnn.Close();


        }
    }
}
