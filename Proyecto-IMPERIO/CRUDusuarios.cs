using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class CRUDusuarios : Form
    {
        SQLControl SQLControl = new SQLControl();
        public CRUDusuarios()
        {
            InitializeComponent();
        }

        private void CRUDusuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        public void AgregarUsuario()
        {
            SQLControl.cnn.Open();
            SqlCommand cmd = new SqlCommand("spAgregarUsuario", SQLControl.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            SQLControl.cnn.Close();
            LimpiarCampos();
        }

        public void ActualizarUsuario()
        {
            SQLControl.cnn.Open();
            SqlCommand cmd = new SqlCommand("spActualizarUsuario", SQLControl.cnn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            SQLControl.cnn.Close();
            LimpiarCampos();
        }

        public void EliminarUsuario()
        {
            SQLControl.cnn.Open();
            SqlCommand cmd = new SqlCommand("spEliminarUsuario",SQLControl.cnn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario",txtusuario.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            LimpiarCampos();
           
            SQLControl.cnn.Close();
        }

        public void LimpiarCampos()
        {
            txtnombre.Clear();
            txtusuario.Clear();
            txtpass.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
            LlenarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
            LlenarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
            LlenarCampos();
        }

        private void CRUDusuarios_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        public void LlenarCampos()
        {
            SQLControl.cnn.Open();
            string consulta = "select * from usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, SQLControl.cnn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SQLControl.cnn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtusuario.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtpass.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}
