using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDusuarios cRUDusuarios = new CRUDusuarios();
            cRUDusuarios.Show();
            Form1 form = new Form1();
            this.Hide();
        }
    }
}
