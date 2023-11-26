using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class cuCalendario : UserControl
    {
        SQLControl con;
        public cuCalendario()
        {
            con = new SQLControl();
            InitializeComponent();
            cbMes.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Replace(" ", "") != "")
            {
                flpCalendario.Controls.Clear();
                int anio = DateTime.Now.Year;
                int mes = (cbMes.SelectedIndex + 1);

                DateTime dia = new DateTime(anio, mes, 1);
                DataTable dt = con.Query("select dia_entrega as fecha from genera where Id_vestido = " + tbCodigo.Text + " and dia_entrega between '" + dia.Date.ToString("yyyy/MM/dd") + "' and '" + dia.AddMonths(1).ToString("yyyy/MM/dd") + "' order by fecha");
                string diasemana = dia.DayOfWeek.ToString();
                int diferencia = 0;
                switch (diasemana)
                {
                    case "Monday":
                        diferencia = 1;
                        break;

                    case "Tuesday":
                        diferencia = 2;
                        break;

                    case "Wednesday":
                        diferencia = 3;
                        break;

                    case "Thursday":
                        diferencia = 4;
                        break;

                    case "Friday":
                        diferencia = 5;
                        break;

                    case "Saturday":
                        diferencia = 6;
                        break;
                }

                while (diferencia != 0)
                {
                    Panel relleno = new Panel();
                    relleno.Size = new Size(88, 86);
                    relleno.BackColor = Color.Gray;
                    relleno.BorderStyle = BorderStyle.FixedSingle;
                    flpCalendario.Controls.Add(relleno);
                    diferencia--;
                }

                while (dia.Month == mes)
                {
                    Panel agregar = new Panel();
                    agregar.Size = new Size(88, 86);
                    agregar.BackColor = Color.White;
                    agregar.BorderStyle = BorderStyle.FixedSingle;

                    Label numero = new Label();
                    numero.Text = dia.Day.ToString();
                    numero.Location = new Point(5, 5);
                    numero.AutoSize = true;
                    numero.BackColor = Color.White;
                    agregar.Controls.Add(numero);

                    foreach (DataRow fila in dt.Rows)
                    {
                        if (dia.Date.ToString("dd/MM/yyyy") == fila[0].ToString().Substring(0, 10))
                        {
                            PictureBox icono = new PictureBox();
                            icono.Size = new Size(50, 60);
                            icono.Location = new Point(18, 12);
                            icono.ImageLocation = "imagenes/icono-vestido.png";
                            icono.SizeMode = PictureBoxSizeMode.StretchImage;
                            dt.Rows.Remove(fila);
                            agregar.Controls.Add(icono);
                            break;
                        }
                    }


                    flpCalendario.Controls.Add(agregar);
                    dia = dia.AddDays(1);
                }

            }
            else MessageBox.Show("Ingresa el codigo del vestido");
        }
    }
}
