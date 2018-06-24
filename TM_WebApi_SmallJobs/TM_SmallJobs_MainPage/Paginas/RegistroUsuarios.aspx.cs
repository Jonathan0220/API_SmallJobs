using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TM_WebApi_SmallJobs.Repository;


namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int registro(string nombre, string correo, string contraseña, string ubicacion, string tipousuario) {
            SqlConnection cnn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionString"));
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("sp_AltaUsuarios", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@Ubicacion", ubicacion);
                cmd.Parameters.AddWithValue("@TipoUsuario", tipousuario);

                var resultado = cmd.ExecuteNonQuery();
                if (resultado != 1) {
                    return 1;
                } else {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                cnn.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int exito = registro(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            switch (exito){
                case 1:
                    //El registro se completo correctamente
                    break;

                default:
                    //Correo ya se esta utilizando
                    break;
            }

        }
    }
}