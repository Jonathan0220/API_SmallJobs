using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.clases;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class NotificacionesGeneral : System.Web.UI.Page
    {

        /*General manda a voluntario 
            
            voluntario = 3
             
             */
        private int idUsuario = Loggin.ID;
        private string tipoUsuario;
        private string Usuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerDatosUsuario();
        }

        private void obtenerDatosUsuario() {
            SqlDataReader rd = getUsuario.getUsuarioid(idUsuario);
            if (rd != null)
            {
                Usuario = Convert.ToString(rd["Nombre"]);
                
            }
        }

       
        protected void sendNotification(object sender, CommandEventArgs e)
        {
            /*  Se manda notificacion a usuario voluntario  */
            string mensaje = "";
            if (e.CommandName.Equals("Rechaza"))
            {
                mensaje = "El usuario " + Usuario + " ha rechazado tu oferta, sigue buscando";

            }
            else if (e.CommandName.Equals("Acepta")) {
                mensaje = "El usuario " + Usuario + " ha aceptado tu oferta, mucha suerte";
            }
            var constr = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Notificacion (idUsuarioActual, idUsuarioDestino, Descripcion) values (" + idUsuario + ", 3, '" + mensaje + "');", cnn);
            cmd.ExecuteNonQuery();


        }
    }
}