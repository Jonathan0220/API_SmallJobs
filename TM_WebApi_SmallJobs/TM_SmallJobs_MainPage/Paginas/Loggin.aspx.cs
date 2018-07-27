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
            if (!IsPostBack) {
                lblValidacion.Text = "";
                txtContraseña.Text = "";
                txtCorreo.Text = ""; 
            }
            
            
        }

        public int Login(string correo, string contraseña) {

            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionString"));
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


                        if (dr != null && dr.Read())
                        {
                            ID = Convert.ToInt32(dr["idUsuario"]);
                            tipoUsuario = Convert.ToString(dr["tipoUsuario"]);
                            return 1;
                        }
                        else {
                            return 0;
                        }
                    }
                    else {
                        return 0;
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
            } else {
                return 0;
            }
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            var respuesta = Login(txtCorreo.Text, txtContraseña.Text);
            if (respuesta == 1)
            {
                lblValidacion.Text = "";
                switch (tipoUsuario)
                {

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
            else {
                lblValidacion.Text = "Usuario y/o Contraseña Incorrectos";
                txtContraseña.Text = "";
                txtCorreo.Text = "";
            }
            
        }

        protected void Registrar_click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarUsuarios.aspx");
        }
    }
}