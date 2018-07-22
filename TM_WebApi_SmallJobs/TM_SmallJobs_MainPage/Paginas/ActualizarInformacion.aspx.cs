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
            SqlConnection cnn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionString"));
            cnn.Open();
            SqlCommand cmdUpdVacante = new SqlCommand("sp_ActualizaUsuario", cnn);
            cmdUpdVacante.CommandType = CommandType.StoredProcedure;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Nombre"].Value = txtNombre.Text;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Correo"].Value = txtCorreo.Text;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Contraseña"].Value = txtContraseña.Text;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Ubicacion", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Ubicacion"].Value = txtUbicacion.Text;

            cmdUpdVacante.ExecuteNonQuery();

            cnn.Close();

            obtenerDatosUsuario();

        }
    }
}