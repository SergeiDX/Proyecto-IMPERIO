using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmVestido : Form
    {
        SQLControl cone;
        cuCrudVestidos crud;
        string foto;
        public frmVestido(cuCrudVestidos crud)
        {
            this.crud = crud;
            cone = new SQLControl();
            InitializeComponent();
            btnAccion.Text = "Agregar";
            foto = null;
        }

        public frmVestido(cuCrudVestidos crud,string id)
        {
            this.crud = crud;
            cone = new SQLControl();
            InitializeComponent();
            btnAccion.Text = "Actualizar";
            tbCodigo.Enabled = false;

            DataTable datos = cone.Query("select * from Vestidos where Id_vestido ="+id);
            tbCodigo.Text = datos.Rows[0].ItemArray[0].ToString();
            pbFoto.ImageLocation = datos.Rows[0].ItemArray[1].ToString();
            tbTalla.Text = datos.Rows[0].ItemArray[2].ToString();
            tbPrecio.Text = datos.Rows[0].ItemArray[3].ToString();
            tbDescripcion.Text = datos.Rows[0].ItemArray[4].ToString();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foto = ofd.FileName;
                pbFoto.ImageLocation = foto;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Replace(" ", "") != "" && tbDescripcion.Text.Replace(" ", "") != "" && tbPrecio.Text.Replace(" ", "") != "" && tbTalla.Text.Replace(" ", "") != "" && pbFoto.ImageLocation != null)
            {
                try
                {
                    if (btnAccion.Text == "Agregar")
                    {
                        if (!cone.ExisteVestido(tbCodigo.Text))
                        {
                            foto = "imagenes/" + tbCodigo.Text + ".png";
                            pbFoto.Image.Save(foto);
                            cone.AgregarVestido(tbCodigo.Text, foto, tbTalla.Text, tbPrecio.Text, tbDescripcion.Text);
                            crud.LlenarVestidos();
                            Close();
                        }
                        else
                            MessageBox.Show("Ya existe un vestido con ese codigo");
                    }
                    else
                    {
                        foto = "imagenes/" + tbCodigo.Text + ".png";
                        pbFoto.Image.Save(foto);
                        cone.ActualizarVestido(tbCodigo.Text, foto, tbTalla.Text, tbPrecio.Text, tbDescripcion.Text);
                        crud.LlenarVestidos();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Llena todos los campos");

            
        }


    }
}
