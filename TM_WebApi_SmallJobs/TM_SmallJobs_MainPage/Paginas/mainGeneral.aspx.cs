using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.clases;


namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class mainGeneral : System.Web.UI.Page
    {
        private int idUsuario = Loggin.ID;
        private string tipoUsuario;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            obtenerDatosUsuario();
        }

        private void obtenerDatosUsuario()
        {
            SqlDataReader rd = getUsuario.getUsuarioid(idUsuario);
            if (rd != null)
            {
                lblNombre.Text = Convert.ToString(rd["Nombre"]);
                tipoUsuario = Convert.ToString(rd["tipoUsuario"]);
            }
        }



        protected void Button_ModalClick(object sender, EventArgs e)
        {

        }
    }
}