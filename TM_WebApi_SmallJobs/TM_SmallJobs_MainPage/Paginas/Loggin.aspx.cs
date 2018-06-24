using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TM_WebApi_SmallJobs.Repository;
using System.Data.SqlClient;
using System.Data;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class Loggin : System.Web.UI.Page
    {
        public static int ID;
        private string tipoUsuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public void Login(string correo, string contraseña) {

            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionStringADO"));
            if (conn != null)
            {
                try
                {
                    conn.Open();
                SqlCommand cmd = new SqlCommand("sp_loggin", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    if (cmd != null)
                    {
                        SqlDataReader dr = cmd.ExecuteReader();


                        if (dr != null && dr.Read()){
                            ID = Convert.ToInt32(dr["idUsuario"]);
                            tipoUsuario = Convert.ToString(dr["tipoUsuario"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Login(txtCorreo.Text, txtContraseña.Text);
            switch (tipoUsuario) {
                
                case "Admin":
                    Response.Redirect("mainAdmin.aspx");
                    break;
                case "General":
                    Response.Redirect("mainGeneral.aspx");
                    break;
                case "Voluntario":
                    Response.Redirect("mainVoluntario.aspx");
                    break;
                default:
                    Response.Redirect("Loggin.aspx");
                    break;
            }
        }
    }
}