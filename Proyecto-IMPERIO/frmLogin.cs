using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_IMPERIO
{
    public partial class frmLogin : Form
    {
        SQLControl sqLControl = new SQLControl();
        
        
        
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            int resultado = sqLControl.login(txtUser.Text, txtPassword.Text);
            Properties.Settings.Default.usuario = txtUser.Text;
            
            if (resultado == 1)
            {
                
                frmMenu menu = new frmMenu();
                Hide();
                menu.Show();
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
            frmCRUDusuarios cRUDusuarios = new frmCRUDusuarios(this);
            cRUDusuarios.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta();
            frmVenta.Show();
            Hide();
        }
    }
}
