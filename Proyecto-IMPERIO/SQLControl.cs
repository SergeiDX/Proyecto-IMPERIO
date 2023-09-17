using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_IMPERIO
{
    internal class SQLControl
    {
        public SqlConnection cnn =
            new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Imperio_Vestidos;Integrated Security=True");


        public DataTable Query(string query)
        {
            cnn.Open();
            SqlDataAdapter read = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            read.Fill(dt);
            read.Dispose();
            cnn.Close();
            return dt;
        }

        public int login(string usuario, string pass)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }

        public void AgregarVestido(string id,string imagen,string talla,string precio,string descripcion)
        {
        
                try
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("Agregar_Vestidos", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("Id_vestido", id);
                    cmd.Parameters.AddWithValue("imagen", imagen);
                    cmd.Parameters.AddWithValue("talla", talla);
                    cmd.Parameters.AddWithValue("precio", precio);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se agrego el vestido correctamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    cnn.Close();
                }
            
        }

        public void ActualizarVestido(string id, string imagen, string talla, string precio, string descripcion)
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Actualizar_Vestido", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id_vestido", id);
                cmd.Parameters.AddWithValue("imagen", imagen);
                cmd.Parameters.AddWithValue("talla", talla);
                cmd.Parameters.AddWithValue("precio", precio);
                cmd.Parameters.AddWithValue("descripcion", descripcion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizo el vestido correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        public void EliminarVestido(string id)
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Borrar_Vestido", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id_vestido", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se elimino el vestido correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        public bool ExisteVestido(string id)
        {
            return Query("select * from Vestidos where Id_vestido=" + id).Rows.Count != 0;
        }
    }
}
