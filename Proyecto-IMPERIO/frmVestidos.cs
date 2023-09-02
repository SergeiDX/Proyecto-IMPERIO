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
    public partial class frmVestidos : Form
    {
        Form1 frm = new Form1 ();
        public frmVestidos()
        {
            InitializeComponent();
        }

        private void frmVestidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
