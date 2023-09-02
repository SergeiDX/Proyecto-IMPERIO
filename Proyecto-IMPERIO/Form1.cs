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
    public partial class Form1 : Form
    {
        SQLControl sqLControl = new SQLControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int resultado = sqLControl.login(txtUser.Text, txtPassword.Text);

            if (resultado == 1)
            {
                frmVestidos vestidos = new frmVestidos();
                this.Hide();
                vestidos.ShowDialog();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }
    }
}
