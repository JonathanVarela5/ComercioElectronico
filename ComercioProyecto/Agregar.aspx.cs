using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ComercioProyecto
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string s =
                System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into CLIENTE (NOMBRE, CEDULA, DIRECCION, FECHA, TOTALPAGO) values('" +
                TextBox1.Text + "','" + this.TextBox2.Text + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + "','" + TextBox5.Text + "' )", conexion);
            comando.ExecuteNonQuery();
            Label1.Text = "Se agrego correctamente";
            conexion.Close();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string s =
            System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from CLIENTE where CEDULA='" +
                this.TextBox2.Text + "'", conexion);
            comando.ExecuteNonQuery();
            Label1.Text = "Se elimino correctamente";
            conexion.Close();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string s =
            System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update CLIENTE set NOMBRE='" +
                this.TextBox1.Text + "', DIRECCION='" + this.TextBox3.Text + "', FECHA='" + this.TextBox4.Text + "', TOTALPAGO='" + this.TextBox5.Text + "' where CEDULA='" +
                this.TextBox2.Text + "'", conexion);
            comando.ExecuteNonQuery();
            Label1.Text = "Se edito correctamente";
            conexion.Close();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(s))
            {
                conexion.Open();
                string nombre = TextBox1.Text;
                string cedula = this.TextBox2.Text;
                string direccion = this.TextBox3.Text;
                string fecha = this.TextBox4.Text;
                string totalPago = TextBox5.Text;

                SqlCommand comando = new SqlCommand("select * from CLIENTE where NOMBRE = @nombre and CEDULA = @cedula and DIRECCION = @direccion and FECHA = @fecha and TOTALPAGO = @totalPago", conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@totalPago", totalPago);

                SqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    Label1.Text = "El cliente si existe en la base de datos";
                    TextBox1.Text = resultado["NOMBRE"].ToString();
                    this.TextBox2.Text = resultado["CEDULA"].ToString();
                    this.TextBox3.Text = resultado["DIRECCION"].ToString();
                    this.TextBox4.Text = resultado["FECHA"].ToString();
                    TextBox5.Text = resultado["TOTALPAGO"].ToString();
                }
                else
                {
                    Label1.Text = "El cliente no existe en la base de datos";
                }

                resultado.Close();
                conexion.Close();
            }


        }
    }

}



