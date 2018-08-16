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
    public partial class mainVoluntario : System.Web.UI.Page
    {
        private int idUsuario = Loggin.ID;
        private string tipoUsuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
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

        public void BindRepeater()
        {
            var constr = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Vacante", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        RepeaterVacante.DataSource = dt;
                        RepeaterVacante.DataBind();
                    }
                }
            }

        }


        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            RepeaterVacante.ItemCommand += new RepeaterCommandEventHandler(rptData_ItemCommand);
        }

        private void rptData_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "postular") {
                aplicar_vacante(Convert.ToInt32(e.CommandArgument), idUsuario);
            }
        }

        /* Obtener el usuario que publico la vacante*/

        private void aplicar_vacante(int idVacante, int idUsuario) {
            var constr = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_aplicarvacante", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idVacante", idVacante);
            cmd.Parameters.AddWithValue("@idUsuarioActual", idUsuario);

            var resultado = cmd.ExecuteNonQuery();
            switch (resultado) {
                case 1:
                    lblresultado.Text = "Exito";
                    break;

                case -1:
                    lblresultado.Text = "Ya aplico a esta vacante";
                    break;

            }

                
            
        }

    }
}