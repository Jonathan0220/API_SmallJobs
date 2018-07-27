using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.clases;
using TM_WebApi_SmallJobs.Repository;
using System.Data;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class ActualizarInformacion : System.Web.UI.Page
    {
        private int idUsuario = Loggin.ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                obtenerDatosUsuario();
            }
        }

        private void obtenerDatosUsuario()
        {
            SqlDataReader rd = getUsuario.getUsuarioid(idUsuario);
            if (rd != null)
            {
                txtNombre.Text = Convert.ToString(rd["Nombre"]);
                txtCorreo.Text = Convert.ToString(rd["Correo"]);
                txtContraseña.Text = Convert.ToString(rd["Contraseña"]);
                txtUbicacion.Text = Convert.ToString(rd["Ubicacion"]);
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            actualizar_usuario(txtNombre.Text, txtCorreo.Text, txtContraseña.Text, txtUbicacion.Text);
        }

        private void actualizar_usuario(string Nombre, string Correo, string Contraseña, string Ubicacion){
        
            SqlConnection cnn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionString"));
            SqlCommand cmdUpdVacante = new SqlCommand("sp_ActualizaUsuario", cnn);
            cmdUpdVacante.CommandType = CommandType.StoredProcedure;
            cmdUpdVacante.Parameters.AddWithValue("@Nombre", Nombre);
            cmdUpdVacante.Parameters.AddWithValue("@Correo", Correo);
            cmdUpdVacante.Parameters.AddWithValue("@Contraseña", Contraseña);
            cmdUpdVacante.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cnn.Open();
            var resultado = cmdUpdVacante.ExecuteNonQuery();

            cnn.Close();
            
        }
    }
}