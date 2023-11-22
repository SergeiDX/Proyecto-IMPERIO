using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    public partial class frmCRUDusuarios : Form
    {
        frmLogin login;
        SQLControl SQLControl = new SQLControl();
        public frmCRUDusuarios(frmLogin login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void CRUDusuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
        
        public bool ExisteUsuario(string usuario)
        {
            string query = "select * from usuario where nombre = @n";
            SQLControl.cnn.Open();

            SqlCommand cmd = new SqlCommand(query, SQLControl.cnn);
            cmd.Parameters.AddWithValue("@n", usuario);
            DataTable resultado = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(resultado);

            SQLControl.cnn.Close();
            return resultado.Rows.Count != 0;
        }

        public void AgregarUsuario()
        {

            if (!ExisteUsuario(txtusuario.Text))
            {
                SQLControl.cnn.Open();
                SqlCommand cmd = new SqlCommand("Agregar_Usuario", SQLControl.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                cmd.Parameters.AddWithValue("Contrasenia", txtpass.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario agregado correctamente.");
                    LlenarCampos();
                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.ToString());
                    throw;
                }
                SQLControl.cnn.Close();
                LimpiarCampos();
            }
            else
                MessageBox.Show("Ya existe un usuario con ese nombre");
        }

        public void ActualizarUsuario()
        {
            SQLControl.cnn.Open();
            SqlCommand cmd = new SqlCommand("Actualizar_Usuario", SQLControl.cnn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_usuario", txtnombre.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtusuario.Text);
            cmd.Parameters.AddWithValue("@Contrasenia", txtpass.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente.");
                LlenarCampos();
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
            SqlCommand cmd = new SqlCommand("Borrar_Usuario",SQLControl.cnn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_usuario",txtnombre.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente.");
                LlenarCampos();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            SQLControl.cnn.Close();
            LimpiarCampos();
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        public void LlenarCampos()
        {
            string consulta = "select * from Usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, SQLControl.cnn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource =  dt;
        }
        private void CRUDusuarios_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtusuario.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtpass.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

       
    }
}
